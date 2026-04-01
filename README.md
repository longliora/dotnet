## Cài .NET SDK cho Linux

### 1. Cài .NET SDK (Ubuntu/Debian)

Thêm Microsoft package repository:
```bash
wget https://packages.microsoft.com/config/ubuntu/22.04/packages-microsoft-prod.deb -O packages-microsoft-prod.deb
sudo dpkg -i packages-microsoft-prod.deb
````

Cập nhật package:

```bash
sudo apt update
```

Cài .NET SDK (bản mới nhất):

```bash
sudo apt install -y dotnet-sdk-8.0
```

---

### 2. Kiểm tra cài đặt

```bash
dotnet --version
```

---

### 3. Tạo project mới

```bash
dotnet new console -n MyApp
cd MyApp
```

Chạy thử:

```bash
dotnet run
```

---

### 4. (Optional) Liệt kê SDK đã cài

```bash
dotnet --list-sdks
```



✅ 1. Cài .NET (không cần sudo)
  wget https://dot.net/v1/dotnet-install.sh
  chmod +x dotnet-install.sh
  ./dotnet-install.sh --channel 8.0


  
✅ 2. Thêm vào PATH
  export PATH=$PATH:$HOME/.dotnet

👉 Lưu luôn:

  echo 'export PATH=$PATH:$HOME/.dotnet' >> ~/.bashrc
  source ~/.bashrc

  
✅ 3. Fix lỗi ICU (QUAN TRỌNG)
  export DOTNET_SYSTEM_GLOBALIZATION_INVARIANT=1

👉 Lưu luôn:
  
  echo 'export DOTNET_SYSTEM_GLOBALIZATION_INVARIANT=1' >> ~/.bashrc
  source ~/.bashrc

  
✅ 4. Kiểm tra
  dotnet --version




