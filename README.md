# Tupdate
 通用远程更新工具

# 一个带参数的更新程式
## 用法 参数如下
up.exe 1.2 在线升级 新版本升级 http://url.xml
解释： 升级程序 + 本地版本号 + 窗口标题 + 主标题 + 升级XML文件链接
# XML 文件格式如下
~~~
<?xml version="1.0" encoding="utf-8"?>
<update ver="2.0.1.0">
	<Log text="
更新说明：2020/12/12
------------------
2.0.1.0
1.增加_-_-_-_-_-；
2.修复_-_-_-_-_-；
3.完善_-_-_-_-_-；
4.优化_-_-_-_-_-。
"
> 更新日志 </Log>
	<Url link="https://localhost/tmp/update.exe"> 升级包下载地址 </Url>
	<Md5 hash="0123456789abcdef0123456789abcdef"> 升级包文件MD5值 </Md5>
	<FullUrl url="https://localhost/demo.exe"> 完整包下载地址 </FullUrl>
	<FileName name="abc.exe"> 存储文件名 </FileName>
</update>
~~~


