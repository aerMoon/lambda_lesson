﻿/*
 Напишите программу, в которой объявлен делегат, предназначенный для работы с методами, не имеющими аргумента и возвращающими символьный результат. 

Опишите класс, у которого есть текстовое поле, а также закрытое поле, являющееся ссылкой на экземпляр делегата. 
В классе нужно описать открытое свойство, доступное только для чтения. Значением свойства является значение закрытого поля (то есть ссылка на экземпляр делегата). 
Опишите конструктор класса с двумя аргументами: текстовым (тип string) и логическим (тип bool). 
    Первый текстовый аргумент определяет значение текстового поля объекта, 
    второй логический аргумент определяет значение закрытого поля типа делегата. 
    Если второй аргумент истинный, то закрытому полю значением присваивается анонимный метод (или лямбда-выражение), 
    возвращающий результатом первый символ из текстового поля. 
    Если логический аргумент ложный, то закрытому полю значением присваивается анонимный метод (или лямбда выражение), 
    возвращающий результатом последний символ из текстового поля. 

Создайте объекты класса и проверьте функциональность свойства: 
    его можно вызывать как метод, без аргументов, 
    а результатом является первый или последний символ в текстовом поле 
    (в зависимости от того, с каким логическим аргументом создавался объект). 
 * */
using System;

namespace Zadanie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
