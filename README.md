# Tupdate
 通用远程更新工具

# 一个带参数的更新程式
## 用法 参数如下
up.exe 1.2 在线升级 新版本升级 http://url.xml

# XML 文件格式如下
~~~
<?xml version="1.0" encoding="utf-8"?>
<update ver="3.20.11.0">
<Log text="
更新说明：
------------------
3.20.11.0
1.增加 HTML 编辑器"
> </Log>
<Url link="https://"> </Url>
<Md5 hash="1234567890"> </Md5>
<FullUrl link="1234567890"> </FullUrl>
</update>
~~~


