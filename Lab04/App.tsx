import { useState } from "react";
import LoginForm, { type LoginPayload } from "./components/LoginForm.js";

type LoginStatus = "idle" | "loading" | "success" | "error";

interface LoginResponse {
  message: string;
}


function fakeLoginAPI(
  username: string,
  password: string
): Promise<LoginResponse> {
  return new Promise((resolve, reject) => {
    setTimeout(() => {
      if (username === "admin" && password === "1234") {
        resolve({
          message: `Xin chào, ${username}!`,
        });
      } else {
        reject(new Error("Sai tài khoản hoặc mật khẩu!"));
      }
    }, 1500);
  });
}

function App() {
  const [status, setStatus] = useState<LoginStatus>("idle");
  const [message, setMessage] = useState<string>("");
  const [loggedUser, setLoggedUser] = useState<string | null>(null);

  const handleLogin = async ({
    username,
    password,
  }: LoginPayload): Promise<void> => {
    setStatus("loading");
    setMessage("");

    try {
      const result = await fakeLoginAPI(username, password);

      setStatus("success");
      setMessage(result.message);
      setLoggedUser(username);
    } catch (error) {
      const errorMessage =
        error instanceof Error ? error.message : "Đăng nhập thất bại";

      setStatus("error");
      setMessage(errorMessage);
      setLoggedUser(null);
    }
  };

return (
    <div className="app-container">
      <div>
        <LoginForm title="Đăng nhập" onSubmit={handleLogin} />

        {status === "loading" && <p>Đang đăng nhập...</p>}

        {status === "success" && <p className="success-msg">{message}</p>}

        {status === "error" && <p className="error-box">{message}</p>}

        {loggedUser && (
          <p className="current-user">User hiện tại: {loggedUser}</p>
        )}
      </div>
    </div>
  );
}

export default App;