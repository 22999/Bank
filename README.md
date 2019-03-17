---
title: 窗体的移动和隐现
date: 2019-03-12 18:48:24
tags: [C语言]
---
程序实现的功能：以QQ登录窗口为例，实现窗口的移动和隐现
<!--more-->
```c
#include<stdio.h>
#include<Windows.h>
//窗体忽隐忽现
void show(HWND *win)
{
	while (1)
	{
	ShowWindow(*win, SW_HIDE);
	Sleep(500);
	ShowWindow(*win, SW_SHOW);
	Sleep(500);
	}
}
//窗体按照长方形的图案移动
void move(HWND *win)
{
	for (int i = 0; i <= 1000; i += 10)
	{
		SetWindowPos(*win, NULL, i, 0, 300, 400, 1);
		Sleep(30);
	}

	{
		int i = 0;
		while (i <= 400)
		{
			SetWindowPos(*win, NULL, 1000, i, 300, 400, 1);
			Sleep(30);
			i += 10;
		}
	}
	{
		int i = 1000;
		do
		{
			Sleep(30);
			i -= 10;
			SetWindowPos(*win, NULL, i, 400, 300, 400, 1);
		} while (i);
	}
	for (int i = 400; i >0; i -= 10)
	{
		SetWindowPos(*win, NULL, 0, i, 300, 400, 1);
		Sleep(30);
	}

}

void main()
{
	HWND win = FindWindowA("TXGuiFoundation", "QQ");
	if (win == NULL)
	{
		printf("没有找到此窗体");
	}
	//show(&win);
	while (1)
	{
		move(&win);
	}
	//move(&win);
	//SetWindowText(win, "444");
}
```
