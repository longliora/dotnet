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

# Cài .NET SDK lên google studio firebase
### cách 1
sữa file dev.nix thêm  
```
pkgs.dotnet-sdk_10 pkgs.nodejs_22
```
thành:
```
packages = [
    # pkgs.go
    # pkgs.python311
    # pkgs.python311Packages.pip
    # pkgs.nodejs_22
    # pkgs.nodePackages.nodemon
    pkgs.dotnet-sdk_10 pkgs.nodejs_22 
  ];
```
<img width="767" height="225" alt="image" src="https://github.com/user-attachments/assets/28b42e79-e6e1-4dc4-86fd-cb56da8c8187" />

---

### cách 2
 nhấn nút + Add Packages 
 
 <img width="126" height="38" alt="image" src="https://github.com/user-attachments/assets/44e61163-1103-4c72-8eb4-56600f3ae24c" />

---

# extension cho google firebase 
.NET Install Tool của  ms-dotnettools

C# của muhammad-sammy



