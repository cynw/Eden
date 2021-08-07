using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ProposalDisplay : MonoBehaviour
{

    public GameObject projectName;
    public GameObject projectDescription;
    public GameObject projectMoney;
    
    // Start is called before the first frame update
    void Start()
    {
        projectName.GetComponent<Text>().text = "จ้างก่อสร้างถนนผิวจราจรแอสฟัลท์คอนกรีต สายบ้านรวมทรัพย์ - บ้านหนองภิรมย์ หมู่ที่ ๖,๑๖ ตำบลภูน้ำหยด อำเภอวิเชียรบุรี จังหวัดเพชรบูรณ์ โดยวิธีคัดเลือก";
        projectDescription.GetComponent<Text>().text = "ก่อสร้างถนนผิวจราจรแอสฟัลท์คอนกีต กว้าง ๖.๐๐ เมตร ไหล่ทางข้างละ ๑.๐๐ เมตร รวมผิวจราจรกว้าง ๘.๐๐ เมตร ยาว ๙,๔๓๘.๐๐ เมตร หนา ๐.๐๕ เมตร หรือมีพื้นที่ผิวจราจร แอสฟัลท์คอนกรีตไม่น้อยกว่า ๗๕,๕๐๔ ตารางเมตร พร้อมรางระบายน้ำ คสล.ในสายทาง รายละเอียดตามแบบแปลนขององค์การบริหารส่วนจังหวัดเพชรบูรณ์ กำหนด";
        projectMoney.GetComponent<Text>().text = "39558000 บาท";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
