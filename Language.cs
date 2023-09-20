using Godot;
using System;

public partial class Language : OptionButton
{
	public override void _Ready()
	{
	}

	public override void _Process(double delta)
	{
		if (Selected==0 && TranslationServer.GetLocale()!="en")
		{
			TranslationServer.SetLocale("en");
		}
		if (Selected==1 && TranslationServer.GetLocale()!="zh_CN")
		{
			TranslationServer.SetLocale("zh_CN");
		}
		if (Selected==2 && TranslationServer.GetLocale()!="zh_TW")
		{
			TranslationServer.SetLocale("zh_TW");
		}
		if (Selected==3 && TranslationServer.GetLocale()!="lzh")
		{
			TranslationServer.SetLocale("lzh");
		}
		if (Selected==4 && TranslationServer.GetLocale()!="ja")
		{
			TranslationServer.SetLocale("ja");
		}
		if (Selected==5 && TranslationServer.GetLocale()!="ru")
		{
			TranslationServer.SetLocale("ru");
		}
		if (Selected==6 && TranslationServer.GetLocale()!="kr")
		{
			TranslationServer.SetLocale("kr");
		}
		if (Selected==7 && TranslationServer.GetLocale()!="fr")
		{
			TranslationServer.SetLocale("fr");
		}
		if (Selected==8 && TranslationServer.GetLocale()!="se")
		{
			TranslationServer.SetLocale("se");
		}
	}
}
