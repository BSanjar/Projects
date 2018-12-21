/*Функция для измения "большой" картинки*/
function SetImg(selected_url)
{
	var item = document.getElementById('preview');
	item.src = selected_url;
}
/*Функция для отправки данных по средством AJAX*/
function SubmitForm(name,tel,car)
{
	$.ajax(
	{
		method:"POST",
		url:"/Home/Form",
		data:{Name:name,Tel:tel,Car:car}
	}).fail(function()
	{
		alert("При передаче данных произошла ошибка!");
	}).done(function(context){
		alert(context);
	});
}
/*Функция для затемнеие и сдвига полязрение экрана (происходит анимация в экране)*/
$(document).ready(function() {
	$('#header').fadeTo(2000,0.3,function(){
		$('html,body').animate(
		{
			scrollTop:$('#content').offset().top},2000
			);
	});
});
/*Функция для валидации и верификации введенных данных*/
	/*Считывание данных*/
$(document).on('submit','form',function()
{
	var UserName = $('input[name = Name]').val();
	var UserTel = $('input[name = Tel]').val();
	var Car = $('select').val();

	/*валидация*/
	/*Проверка  имя*/
if (UserName.length>0) 
{
	var regular =/^\996-[0-9]{3}-[0-9]{3}-[0-9]{3}/;
	/*Проверка  телефона*/
	if (regular.test(UserTel)==true) 
	{
		alert('Отлично!');
		SubmitForm(UserName,UserTel,Car);
	}
	else
	{
		alert('Вы неверно указали номер телефона!');
	}
}
else
{
	alert('Вы забыли указать имя.');
}
});