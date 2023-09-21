using Godot;
using System;

public partial class main : Control
{
	internal int h=0;
	internal int m=0;
	internal int s=0;
	internal double ms=0;
	internal string ht="00";
	internal string mt="00";
	internal string st="00";
	internal string mst="00";
	internal bool start=false;
	public override void _Ready()
	{
		TranslationServer.SetLocale("en");
		if (OS.GetLocaleLanguage() == "zh" || OS.GetLocale() == "zh_CN" || OS.GetLocale() == "zh_SG")
		{
		    TranslationServer.SetLocale("zh_CN");
		}
		if (OS.GetLocale() == "zh_TW" || OS.GetLocale() == "zh_HK" || OS.GetLocale() == "zh_MO")
		{
		    TranslationServer.SetLocale("zh_TW");
		}
		if (OS.GetLocaleLanguage() == "ja" || OS.GetLocale() == "ja_JP")
		{
		    TranslationServer.SetLocale("ja");
		}
	}

	public void _on_start_pause_pressed()
	{
		if (start)
		{
			GetNode<Button>("StartPause").Text="locContinue";
		}
		else
		{
			GetNode<Button>("StartPause").Text="locPause";
		}
		start=!start;
	}

	public override void _Process(double delta)
	{
		if (start)
		{
			ms+=delta*100;
		}
		if (GetNode<Button>("Reset").ButtonPressed)
		{
			GetNode<Button>("StartPause").Text="locStart";
			start=false;
			h=0;
			m=0;
			s=0;
			ms=0;
			ht="00";
			mt="00";
			st="00";
			mst="00";
		}
		if (ms>=100)
		{
			ms=0;
			s+=1;
		}
		if (s>=60)
		{
			s=0;
			m+=1;
		}
		if (m>=60)
		{
			m=0;
			h+=1;
		}
		if (ms<10)
		{
			mst="0"+((int)ms).ToString();
		}
		else
		{
			mst=((int)ms).ToString();
		}
		if (s<10)
		{
			st="0"+s.ToString();
		}
		else
		{
			st=s.ToString();
		}
		if (m<10)
		{
			mt="0"+m.ToString();
		}
		else
		{
			mt=m.ToString();
		}
		if (h<10)
		{
			ht="0"+h.ToString();
		}
		else
		{
			ht=h.ToString();
		}
		GetNode<Label>("Time").Text=ht+":"+mt+":"+st+":"+mst;
	}
}
