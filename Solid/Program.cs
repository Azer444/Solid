using Solid.App.LSPGood;

BasePhone phone = new IPhone();
phone.Call();
((ItakePhoto)phone).TakePhoto();
phone = new Nokia3310();