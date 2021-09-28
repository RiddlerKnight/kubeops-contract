# Questtions

# Part 1 Normal

1. Describe Git branching strategies (Git-flow, single branch, feature branch etc.) which you have used and what purpose does it serves

   1. `Git-Flow Branch Strategy`

      Git-Flow Strategy เหมาะสำหรับการทำงานที่แบ่งเป็นหลาย ๆ Team ทำแยก feature กัน จะประกอบไปด้วย Branch หลัก ทั้งหมด 5 Branch

      1. `Main or Master` จะเป็น Branch ที่ทุกอย่างพร้อมที่จะ Deploy บน Production จะเป็น latest release เสมอ

      2. `Develop` จะเป็น Branch ที่อยู่ในช่วย Alpha state ควรที่จะสามารถ Build ผ่าน และใช้งานได้ แต่ยังไม่ Stable ซึ่งจะ Feature อาจจะยังไม่ครบตาม Mindstone ที่วางไว้

      3. `Feature` จะเป็น Branch ที่แตกออกมาจาก Develop หรือ Main เพื่อให้ Dev ใน Team ที่รับผิดชอบใน Feature นั้นๆ ได้ Dev บน Feature ของตัวเองได้อย่างไม่ไปกระทบกับ Feature อื่นที่กำลัง Develop อยู่ การตั้งชื่อจะมี pattern แบบนี้ "feature/user-whitelist"

      4. `Realease` จะเป็น Branch ที่ Feature บน mindstone ครบแล้วตาม Roadmap ที่ได้วางไว้ แล้วก็จะสร้าง Branch Realease มาจาก Branch Develop แล้วถ้ามี Bug เพิ่มเติมก็จะแก้กันบนนี้เลย "realease/v2.6.0-r1"

      5. `Hotfix` จะเป็น Branch พิเศษที่ แตกจาก Main หรือ Realease ที่มี Bug หลังจาก Release ไปแล้ว เพื่อแก้ปัญหา Bug เล็กน้อย และจะ merge กลับไปในทุก ๆ branch ที่ working on อยู่ปัจจุบัน

   2. `Single Branch Strategy`

      Single Branch จะเป็นการใช้งาน Branch แค่ Branch เดียวจะไม่มีการแตก Branch ที่วุ่นวาย เหมาะสำหรับ งานที่ทำคนเดียว หรือ ใช้สำหรับ Declarative Config อะไรบางอย่างที่ต้องการเก็บ history ไว้อย่างเดียว

2. How do you revert a commit that has already been pushed and made public?

   ปกติผมจะไม่ Revert ถ้า Code นั้น Public ไปแล้ว จะใช้การ push commit ขึ้นไปแก้ เพื่อป้องกันการสับสน

3. How do you normally solve conflicts in a feature branch before merge?

   ถ้ามี Conflicts เกิดขึ้น เวลา Merge เราจะให้ Team ที่เกี่ยวข้องกับ Conflicts นั้น ๆ มา Review ร่วมกันก่อน เพื่อป้องกันการที่อีก Team ไปลบ Code ที่อีก Team ได้ทำเอาไว้ โดยที่ไม่ตั้งใจ

4. “200 OK” what does it mean and show use case this HTTP Status?

   Api ใช้งานได้ปกติ และมี Data ที่ต้องการส่งกลับมา หรือมีการบันทึกเรียบร้อย

5. “201 Created” what does it mean and show use case this HTTP Status?

   ยืนยันว่าข้อมูลได้รับแล้ว และ return new resource location ที่ได้รับกลับมาด้วย

6. “301 Moved Permanently” what does it mean and show use case this HTTP Status?

   เป็นการ Redirect ไปยัง Url อื่นแทน โดยส่ง location header กลับมา

7. “400 Bad Request” what does it mean and how to identify the problem?

   ถ้าคุณใส่ข้อมูลมาไม่ถูกต้อง ไม่ครบ ก็ได้ Status code นี้กลับมา

8. “401 Unauthorized” what does it mean and how to identify the problem?

   คนไม่มีสิทธิ์เข้าถึงข้อมูลนั้น หรือคุณอาจจะยังไม่ได้ login ถ้าจนปัญญาแล้ว ติดต่อ Admin เลยครับ :-D

9. “403 Forbidden” what does it mean and how to identify the problem?

   Url นี้ห้าม Access ตรงๆ นะครับ WordPress ผมเจอบ่อย :-D

10. “404 Not Found” what does it mean and how to identify the problem?

    ส่วนใหญ่จะเจอถ้า Controller นั้นไม่ได้ map กับ Url นั้น หรือไม่ก็คือ ไม่มี api เส้นนั้นอยู่ ออกไป ชิ่วๆ

11. “500 Internal Server Error” what does it mean and how to identify the problem?

    มีอะไรพังแน่ๆ ดู log ได้เลยครับ

12. “502 Bad Gateway” what does it mean and how to identify the problem?

    Gateway ได้ทำการ Proxy แต่ไม่มีการตอบรับจาก Upsteam server ประมาณว่า LB ยังทำงานปกติ แต่ Server ด้านหลัง ดับไปแล้ว

13. “503 Service Unavailable” what does it mean and how to identify the problem?

    ค่อยๆ คลิกนะครับ User ที่รัก ต่อคิวนะครับ :-D อาจจะเป็นเพราะ Server Overload หรือ Temporary maintenance

14. “504 Gateway Timeout” what does it mean and how to identify the problem?

    Gateway ได้ทำการ Proxy แล้ว เชื่อมต่อ Server Upsteam ได้ แต่ไม่ Response มาในระยะเวลาที่กำหนด อาจจะต้องเช็ค logic หลังบ้านว่าทำไมถึงช้า

15. What are Linux network tools do you use for troubleshooting network problems as well as usage scenarios for each tool?

    `ping` อันนี้ classic เช็ค ip เครื่องนั้นๆ ว่าเจอไหม ออก net ได้หรือปล่าว Latency เท่าไหร่ ping ใช้ protocal icmp port 1 \
    `hostname` สำหรับดูว่า Hostname ของเครื่องชื่ออะไร \
    `netstat` สำหรับดูว่ามีการเชื่อมต่ออะไรอยู่บ้าง port ไหน IP อะไร ใช้รวมกับ grep จะดีมาก \
    `telnet` tool ใช้ประจำไว้เช็ค port นั้นๆ ว่าเปิดอยู่หรือไม่ \
    `curl` ไว้เช็ค url ไว้ใช้ Download หรือ เปิดเว็ป นั้นๆ ได้ เพื่อ Test Service ต่างๆ หรือเช็ค Header ที่ส่งกลับมา
    `nmap` scan port หลักเลย \
    `dig` ไว้เช็ค hostname ว่าชี้ไปที่ Ip อะไร ใช้เวลาเปลี่ยน dns \
    `nslookup` คล้ายๆ dig ครับ \
    `host` เช็ค DNS record ได้ \
    `ifconfig` เช็ค Ip เครื่องตัวเอง หรือ network interface ที่มีอยู่บนเครื่องเรา

## Part 2 Intermediate

1.  Assume we have an application that is designed as below. Our application stopped responding due to an extremely high number of clients in some circumstances.
    We have tried scaling a number of API Gateway and Service A nodes but it didn’t help. What are the possible problems that lies in our system in which components and how to fix them?

        อาจจะมาจาก `Backing Service` such as DB, Caching Server (Redis,Memcache) ควร inspect DB ว่า Overload หรือไม่ Overload จาก การ Query ที่ผิดปกติหรือปล่าว อาจจะเกิดการการเขียน query ที่ไม่ถูกต้อง ก็เป็นไปได้ แล้วถ้าดูแล้ว code ปกติ ก็คงต้อง Scale up Backend Service ขั้นต่อไป

2.  How do you keep the docker image smallest as possible?

    1. แบ่ง State ในการ Build, Release
    2. เน้นใช้ base image ที่เป็น slim
    3. ขั้นสุดคือ Build from scratch เฉพาะ App เราและ Runtime, lib ที่เราจะใช้เท่านั้น

3.  What is the difference between overlay, bridge, host network in Docker? When to use each of them?

    1. `bridge network` เป็น Default network driver ซึ่งจะสามารถเชื่อมต่อกับ container อื่นๆ ได้บน Bridge network เดียวกัน จะแบ่งออกเป็น 2 แบบ default bridge กับ defined bridge เราใช้ defined bridge เมื่อต้องการ network isolation
    2. `host networking` เมื่อ Run mode นี้ container ที่เรา run จะไม่ isolate network จาก docker host ซึ่งจะไม่ได้รับ IP แต่ภายใน แต่จะใช้ IP ของ Host นั้นแทน อันนี้จะได้เรื่อง Performance ด้วยเพราะ ลด network layer ลง เหมาะสำหรับบางกรณีที่ run container แบบ stanalone
    3. `Overlay network` จะเห็นการสร้าง distrubuted network ที่สามารถเชื่อมต่อระหว่าง docker daemon host ได้ จะทำให้ container สามารถ communicate กันกับอีก container นึ่งที่อยู่ คนละ host ได้ และปลอดภัยเพราะมีการ encrypt ไว้ด้วย

4.  How does the Kubernetes service talk to each other in the same cluster?

    เมื่อเรา create pod ขึ้นมาแล้ว pod จะยังไม่มี ClusterIP ทำให้ไม่สามารถคุยกันระหว่าง service ได้ เราจะต้อง create service resource เพื่อ bind port จาก container (target port) แล้วกำหนด port ที่เราจะ expose ออกมา เมื่อเรา Create เรียบร้อยแล้วก็จะได้ ClusterIP มา แต่เวลาเราเรียกหา Service นั้น เราจะใช้ชื่อ \<protocol\>://\<service name\>.\<namespace\> ในการเรียกหากัน โดย CoreDns จะมีหน้าที่ translate ชื่อ Service เหล่านั้นเป็น ClusterIP

5.  What’s different between L2, L4, and L7 Load balancers? When to use it?

    อันนี้อยู่ในเรื่องของ OSI Network layer ซึ่ง Load balancers จะสามารถ routing/proxy บน Layer ในแต่ละระดับที่กำหนดไว้ เช่น L2 ก็คือสามารถ routing ในระดับ Layer2 ที่เจอก็คือจะเป็นตัว metallb ซึ่งจริงๆ เป็นการจำลอง network layer นี้ขึ้นมา เพื่อทำให้เกิด failover mechanism เพื่อที่จะใช้ทุก node สามารถเป็น Leader node ได้ ถ้าอีก node fail

    L4 จะสามารถ routing บนระดับ TCP/IP protocol (routing ด้วย IP addr / port) ทำหน้าที่คล้ายๆ NAT

    L7 จะสามารถ routing ในระดับ application layar ได้เช่น routing ด้วย url path, header, etc.

## Part 3 Profressional

1. Assume that you are using a private cloud for your infrastructure. How do you manage logs, metrics, and alerts for your infrastructure and applications? Which tools do you use and why?

   จริงๆ มีหลายๆ ตัวให้เลือกใช้เช่น VSphere, OpenStack ที่หลักๆ แล้ว stack ที่ว่ามาจะเป็น on-top ที่จะ manage hardware บน Private cloud ของเราเองซึ่งมา companent หลักๆ ให้เราเลือกใช้ได้สะดวก ซึ่งสามารถจัดการ storage unit (SAN storage) แยกออกจาก processing unit (CPU and GPU) หรือจะใช้ kvm ในการจัดการตรงนี้ก็ทำได้ (ผมเคยใช้แต่ VSphere T-T)

   หลังจากนั้นเราสามารถลง Kubernetes เพื่อใช้ในการทำ Infra as code ได้ สะดวกมากขึ้น โดยสามารถเก็บ log, metrice โดยใช้ elasticsearch/prometeus โดยสามารถใช้ fluentd ในการ collect log จาก pod ได้ หรือบางกรณีผมจะลงตัว APM เพื่อเก็บ Log เชิงลึกบางอย่างจาก application โดยตรงได้เลย ส่วน alert อันนี้ ไม่ว่าจะเป็น elasticsearch หรือ prometeus สามารถ ทำ webhook ได้

2. How do you secure the following?

   - application

     - Secure by design -> มีการจำกัดสิทธิ์เข้าถึง resource ต่าง ๆ scan depencies ทุกครั้งเมื่อ build \
     - Secure by default -> Setting บางอย่างที่ sensitive ควร Disable by defualt \
     - Secure by deployment -> Secret เราจะเก็บแยกไม่อยู่รวมกับ Code และเรียกใช้จาก role ที่กำหนดไว้เท่าที่จำเป็นเท่านั้น

   - infrastructure
   - data

3. Base on your experience, how do you reduce your service downtime as much as possible during

   - software upgrade
   - database migration
   - incident

4. Configuration management

   - a. Which Among Puppet, chef, Ansible, or another is the best Configuration management tool?
   - b. Why?
   - c. Do you still need to use it if you already have docker-swarm or Kubernetes?

5. How do you design your Kubernetes cluster? what DNS, CNI, ingression is being used? Why?

6. How do you measure service quality to give the best experience to your customer? (SLO, SLA)
