import { useState, type FormEventHandler } from "react";
import InputField from "./InputField.js";

export interface LoginPayload {
  username: string;
  password: string;
}

type SubmitHandler = (payload: LoginPayload) => Promise<void> | void;

interface LoginFormProps {
  title: string;
  onSubmit: SubmitHandler;
}

interface LoginErrors {
  username?: string;
  password?: string;
  form?: string;
}

function LoginForm({ title, onSubmit }: LoginFormProps) {
  const [username, setUsername] = useState<string>("");
  const [password, setPassword] = useState<string>("");
  const [errors, setErrors] = useState<LoginErrors>({});
  const [isSubmitting, setIsSubmitting] = useState<boolean>(false);

  const validate = (): LoginErrors => {
    const newErrors: LoginErrors = {};

    if (!username.trim()) {
      newErrors.username = "Vui lòng nhập tên đăng nhập";
    }

    if (!password.trim()) {
      newErrors.password = "Vui lòng nhập mật khẩu";
    } else if (password.length < 4) {
      newErrors.password = "Tối thiểu 4 ký tự";
    }

    return newErrors;
  };

  const handleSubmit: FormEventHandler<HTMLFormElement> = async (e) => {
    e.preventDefault();

    const validationErrors = validate();

    if (Object.keys(validationErrors).length > 0) {
      setErrors(validationErrors);
      return;
    }

    try {
      setErrors({});
      setIsSubmitting(true);

      await onSubmit({
        username,
        password,
      });
    } catch {
      setErrors({
        form: "Đăng nhập thất bại. Vui lòng thử lại.",
      });
    } finally {
      setIsSubmitting(false);
    }
  };

  return (
    <form className="login-form" onSubmit={handleSubmit}>
      <h2 className="form-title">{title}</h2>

      <InputField
        label="Tên đăng nhập"
        type="text"
        value={username}
        onChange={(e) => setUsername(e.target.value)}
        placeholder="Nhập tên đăng nhập..."
        error={errors.username}
      />

      <InputField
        label="Mật khẩu"
        type="password"
        value={password}
        onChange={(e) => setPassword(e.target.value)}
        placeholder="Nhập mật khẩu..."
        error={errors.password}
      />

      {errors.form && <span className="error-msg">{errors.form}</span>}

      <button type="submit" className="login-btn" disabled={isSubmitting}>
        {isSubmitting ? "Đang đăng nhập..." : "Đăng nhập"}
      </button>
    </form>
  );
}

export default LoginForm;