lưu ý: để tạo bằng  control + shift + p á thì mỗi project nằm trong 1 thư mục riêng!
vd /nullsafe(thư mục này chưa project)/nullsafe(đây chính là nơi mà chạy lệnh project)/
nếu mà tất cả project đều ở trong 1 thư mục thì khi tạo project Tự động thêm project vào một solution đang tồn tại ✅


dotnet new sln -n MySolution
=> slnx để quản lý các project


cách thêm 1 project vào slnx (slnx tạo bằng lệnh k phải ctrl + shift + p):
1. Tốt nhất nên để .NET CLI tự thêm project:
 dotnet sln add NullSafe/NullSafe.csproj

2. tạo project
dotnet new console -n Delegate


### tạo thêm page

dotnet new page -n About -o Pages
* Giải thích:
 -n About: Đặt tên trang là About.
 -o Pages: Đặt file vào thư mục Pages


### lệnh tạo razer page:

dotnet new webapp -o name

### model(class) và Components và thư mục Components  chứa các Components và service đc tạo bằng tay.
<a (Lưu ý: tên file = Tên component + “ViewComponent”.cs  luôn luôn có chữ ViewComponent ở cuối) a>
Đặt tên file là: Default.cshtml
<a (Lưu ý: tên file luôn là Default.cshtml) a>


Đặt tên file là: BestSellersViewComponent.cs
<a (Lưu ý: tên file = Tên component + “ViewComponent”.cs  luôn luôn có chữ ViewComponent ở cuối)>

rm -rf .git

git init
echo ".codespaces/" >> .gitignore
git add .
git commit -m "init clean"
git branch -M main
git remote add origin https://github.com/longliora/dotnet
git push -u origin main --force