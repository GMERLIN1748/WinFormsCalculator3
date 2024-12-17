# WinFormsCalculator3
WinFormsCalculator2
# Calculator

by krittin Intrakool,
673450030-6,
Computer and Infomation Science, KKU

# การรับและการแสดงผลข้อมูล

รับข้อมูลจากผู้ใช้งาน และทำงานผ่านการกดปุ่มเพื่อคำนวนตัวเลข

## ปุ่มบวก

```
private void button1_Click(object sender, EventArgs e)
{
    // ข้อความตัวอักษร
    string inputNum1 = num1.Text;
    string inputNum2 = num2.Text;
    // convert string to number (integer)
    int iNum1 = Int32.Parse(inputNum1);
    int iNum2 = Int32.Parse(inputNum2);
    // int ทำให้เราสามารถทำการ + - * / ได้
    int iResult = iNum1 + iNum2;
    // ที่ตัวแปรชื่อ result
    // มีคุณสมบัติชื่อ Text
    result.Text = iResult.ToString();
}
```

### รับข้อมูล

ตัวอย่าง

```
string input = num1.Text();-
```

### แปลงชนิดของข้อมูล

ตัวอย่าง

```
 double iNum1 = Double.Parse(inputNum1);
    double iNum2 = Double.Parse(inputNum2);
```

### คำนวนผลลัพท์

ตัวอย่าง

```
double iresult = iNum1 - iNum2;
```

### แสดงผล

ตัวอย่าง

```
result.Text = iresult.ToString();
```

## ปุ่มลบ
{
    string inputNum1 = num1.Text;
    string inputNum2 = num2.Text;
    double iNum1 = Double.Parse(inputNum1);
    double iNum2 = Double.Parse(inputNum2);
    double iresult = iNum1 - iNum2;
    result.Text = iresult.ToString();
}
## ปุ่มคูณ
{
    string inputNum1 = num1.Text;
    string inputNum2 = num2.Text;
    double iNum1 = Double.Parse(inputNum1);
    double iNum2 = Double.Parse(inputNum2);
    double iresult = iNum1 * iNum2;
    result.Text = iresult.ToString();
}
## ปุ่มหาร
{
    string inputNum1 = num1.Text;
    string inputNum2 = num2.Text;
    double iNum1 = Double.Parse(inputNum1);
    double iNum2 = Double.Parse(inputNum2);
    double iresult = iNum1 / iNum2;
    result.Text = iresult.ToString();
}
## ปุ่มลบข้อมูล
{
    num1.Clear();
    num2.Clear();
    result.Clear();
}
