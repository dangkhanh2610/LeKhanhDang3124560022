import type { ChangeEventHandler } from "react";

type InputType = "text" | "password";

interface InputFieldProps {
  label: string;
  type: InputType;
  value: string;
  onChange: ChangeEventHandler<HTMLInputElement>;
  placeholder?: string | undefined;
  error?: string | undefined;
}

function InputField({
  label,
  type,
  value,
  onChange,
  placeholder,
  error,
}: InputFieldProps) {
  return (
    <div className="input-group">
      <label className="input-label">{label}</label>

      <input
        type={type}
        value={value}
        onChange={onChange}
        placeholder={placeholder}
        className={`input-field ${error ? "input-error" : ""}`}
      />

      {error && <span className="error-msg">{error}</span>}
    </div>
  );
}

export default InputField;