using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media.Imaging;

namespace CTUMobile
{
    class CampusList
    {
        private static string br = "\n";

        public List<Campus> campuses = new List<Campus>
        {
            new Campus(){
                Id = 0,
                CampusName = "CTU Roodepoort",
                CampusDescription = "CTU Roodepoort creates the opportunity for students of diverse cultures and backgrounds to come together and share a common love and interest for a career in the IT industry. We offer students a learning environment where they can achieve their full potential and rise above the norm. CTU Roodepoort works closely with students to ensure that each student feels accepted and supported during their studies throughout the year. During the year we also have various Campus activities, where students can experience Student Life @ CTU Roodepoort such as gaming weekends and fun open days throughout the year. So, come to CTU Roodepoort and start your future with us! ",
                CampusContact = $" {br} Call us : 011 760 4321 {br} FAX : 011 760 2905 {br} Email us : enquiry@ctutraining.co.za {br} Our Address : Shop 59, The Village @ Horizoncnr Sonop & Ontdekkers Road, Horizon Roodepoort, Johannesburg",
                CampusCourses = new Dictionary<string, string>
                {
                    {$"{br} Software and Application Development:MCSD ", $" {br} Purpose : Demonstrate your expertise at designing and developing fast and fluid applications that are the focal point of the user experience. Prove that you have the skills and techniques needed to design, build and deploy solutions that deliver more data to more people across the organization.  {br} National Qualification : QCTO National Certificate IT Database Development, QCTO National Certificate IT Systems Development {br} International Qualification : MCSD: App Builder, MCSA:SQL 2016 Database Infrastructure ,MCSA:SQL 2016 BI Development ,MCSA:SQL 2016 Database Admin {br}" },
                    {$"{br} Web Development ", $" {br} Purpose : Web development is a broad term for the work involved in developing a website. Among web professionals, “web development” usually refers to the main non-design aspects of building websites: writing mark-up & coding. Web development can range from developing the simplest static single page of plain text to the most complex web-based internet applications, electronic businesses, or social network services.  {br} National Qualification : QCTO FET Certificate: Systems Developmen, QCTO National Certificate: IT(Systems Development) {br} International Qualification : ACA (Adobe Certified Associate) Photoshop CC, ACA (Adobe Certified Associate) Animate CC, ACA (Adobe Certified Associate) Dreamweaver CC, CIW Web Foundations Associate, CIW Social Media Strategist, CIW Advanced HTML5, CSS3 & JavaScript Specialist, CIW E-Commerce, CIW User Interface Designer, CIW Mobile Application Developer " }
                },
                CampusActivities = "Friday LAN Night, Womens Day",
                CampusVideos = new Uri("ms-appx:///CampusAssets/CampusVideos/Roodepoort/Roodepoort.mp4"),
                CampusLocation = new Uri("ms-appx:///CampusAssets/CampusMaps/Roodepoort/Roodepoort.png"),
                CampusImage = new BitmapImage(new Uri("ms-appx:///CampusAssets/CampusImage/Roodepoort/RoodepoortShow.jpg")),
                MapLat = -26.142775,
                MapLong = 27.870035
            },
            new Campus()
            {
                Id = 1,
                CampusName = "CTU Sandton",
                CampusDescription = "At CTU Sandton we promise to provide our customers a high end learning experience driven by expert-led industry consultants, delivering relevant, world-class technologically advanced skills. CTU Sandton is a collaborative environment that provides access to innovative learning and world-class expertise, enabling you to experience learning in a unique way. Whether you are looking to learn a new technology or send your team for a bootcamp training experience, you can count on Sandton to bring you that high end, value for money learning experience that you expect.",
                CampusContact = $" {br} Call us : 011 666 7431 {br} Email us : enquiry@ctutraining.co.za {br} Our Address : Suite 21, Second Floor, Daisy Street Office Park 135 Daisy Street, Sandown Sandton, Johannesburg",
                CampusCourses = new Dictionary<string, string>
                {
                    {$"{br} Tourism", $" {br} Purpose : Are you looking for a field that offers hundreds of exciting careers around the world? You’ve found it! Tourism & hospitality is one of the fastest growing sectors both locally and internationally. If you’re dreaming of being in a management role in the tourism, travel or hospitality industries, then this is the programme for you.  {br} International Qualification : CTH Level 3 Diploma* in Tourism & Hospitality – QCF 600/7003/1, CTH Level 4 Diploma* in Tourism & Hospitality – QCF 600/7089/4, CTH Level 5 Advanced Diploma* in Tourism & Hospitality – QCF 600/7091/2" },
                    {$"{br} Graphic Design", $" {br} Purpose : The purpose of this qualification is to provide a foundation for a variety of design-orientated fields, in that the student gains competencies in the generic processes of various design specialisations. Graphic designers work with images, text and media. They utilize advanced technology to create visual and multimedia presentations. Multimedia designers integrate audio, animation, graphics and video into presentations for CDs, DVDs, television programmes and websites. {br} National Qualification : QCTO FET Certificate: Design Foundation, QCTO National Certificate: Design Techniques {br} International Qualification : ACA (Adobe Certified Associate) Photoshop CC ACA (Adobe Certified Associate) Illustrator CC, ACA (Adobe Certified Associate) inDesign CC ACA (Adobe Certified Associate) Animate CC" }
                },
                CampusActivities = "Saturday Campus Cross Dress Competition, Womens Day ",
                CampusVideos = new Uri("ms-appx:///CampusAssets/CampusVideos/Sandton/Sandton.mp4"),
                CampusLocation = new Uri("ms-appx:///CampusAssets/CampusMaps/Sandton/Sandton.png"),
                CampusImage = new BitmapImage(new Uri("ms-appx:///CampusAssets/CampusImage/Sandton/SandtonShow.jpg")),
                MapLat = -26.100797,
                MapLong = 28.063113 
            },
            new Campus()
            {
                Id = 2,
                CampusName = "CTU Pretoria",
                CampusDescription = "This is the place to start your IT Career! CTU Pretoria Career is the best Campus ever! There you will find a healthy balance between work & play! CTU Pretoria Career offers all kinds of student activities that take place during your time of study! They are part of TUKS RAG every year! You will get to build a CTU float and have awesome FUN! CTU Pretoria Career arranges program specific Field Trips to the Industry! CTU Pretoria Career is next to the Menlyn Shopping Centre which means that after school hours, the student-life fun can just continue into early hours. Public transport routes are also close to the Campus! So come to Pretoria Careers Campus and see for yourself why it is the best campus ever!",
                CampusContact = $" {br} Call us : 012 361 6688 \012 470 9500 {br} Email us : enquiry@ctutraining.co.za {br} Fax : 012 348 8394 {br} Our Address : Glen Manor Office Park, Block 6 Frikkie de Beer Street Menlyn, Pretoria",
                CampusCourses = new Dictionary<string, string>
                {
                    {$"{br} IT Technical Support", $" {br} Purpose : The outcome of this programme creates entry-level systems support professionals with good fundamental knowledge of the information technology field, coupled with interpersonal and business skills, allowing for specialisation in various systems support fields. {br} National Qualification : QCTO FET Certificate: IT Technical Support, QCTO National Certificate: IT Systems Support, After IT Technical Support I: QCTO National Certificate: IT Systems Support, After IT Technical Support II: The national qualification is the same as IT Technical Support II. The benefit of doing this programme as a 3rd year, is the international certifications. Additional 10 credits of SAQA ID 50080 {br} International Qualification : 220-901 CompTIA A+ Hardware, 220-902 CompTIA A+ Software, 70-698 Installing and Configuring Windows 10, N10-006* CompTIA Network+, 70-740 Installation, Storage and Compute with Windows Server 2016, 70-741 Networking with Windows Server 2016, 70-742 Identity with Windows Server 2016, 98-367 Security Fundamentals, CS0-001* CompTIA Cyber Security Analyst+, MTA 98-366* Network Fundamentals, 200 – 125** CCNA Routing and Switching, 210 – 451 CCNA Cloud ,640 – 461 CCNA Voice, CS0-001* Cyber Security" },
                    {$"{br} Entrepreneurship", $" {br} Purpose : Dreaming to start, manage and develop a small or medium-sized business? Every entrepreneur need to be financially-minded to make your business a success. Ensure your existing or future company runs efficiently by acquiring the necessary skills and knowledge. Students doing this specific programme will obtain accounting, commercial and financial skills that will help them be successful in the business sector. Other skills include personal skills, strategy and technical knowledge.  {br} National Qualifications : QCTO National Certificate: Small Business Financial Management {br} International Qualification : QCTO Higher Certificate: Office Administration (SAQA ID 23619, NQF 5, 240 Cumulative Credits)Certificate issued by ICB, QCTO National Diploma: Financial Accounting (SAQA ID 20366, NQF 6, 280 Cumulative Credits)" }
                },
                CampusActivities = "Graphics Competition Finals, Womens Day",
                CampusVideos = new Uri("ms-appx:///CampusAssets/CampusVideos/Pretoria/Pretoria.mp4"),
                CampusLocation = new Uri("ms-appx:///CampusAssets/CampusMaps/Pretoria/Pretoria.png"),
                CampusImage = new BitmapImage(new Uri("ms-appx:///CampusAssets/CampusImage/Pretoria/PretoriaShow.jpg")),
                MapLat = -25.782770,
                MapLong = 28.279011
            },
            new Campus()
            {
                Id = 3,
                CampusName = "CTU Auckland Park",
                CampusDescription = "Auckland Park is committed to provide world class IT education. They offer a warm and supportive environment in which you can grow in confidence and resilience, as well as a focussed curriculum program that develops a student’s potential to the maximum. CTU Auckland Park boasts with facilitators who are committed to excellence in the learning and teaching process and who value the capacity of each student to grow through effective learning. They provide fair, firm and consistent discipline to ensure that the teaching and learning process is not compromised. This allows high expectations in all aspects of behaviour and academic progression. CTU Auckland Park believes in effective channels of communication, ensuring that all parents or guardians are well informed of all events, activities and student learning. CTU Auckland Park also helps with opportunities for workplace experience. Come visit CTU Auckland Park and see what we can offer you!",
                CampusContact = $" {br} Call us : 011 482 7422 {br} Email us : enquiry@ctutraining.co.za {br} Our Address : 3rd floor Curatio Building, 3 Annet Road, Auckland Park",
                CampusActivities = "Womens Day, Lan Night, Mr. and Mrs. Aucland",
                CampusCourses = new Dictionary<string, string>
                {
                    {$"{br} Diploma: Visual Communication", $" {br} Purpose : Visual communication (also referred to as graphic design) implies the development of design solutions to persuade, entertain, inform, and educate an observing audience regarding products, services and ideas. The field of visual communication encompasses the development of corporate identity, packaging design, editorial design, promotional campaigns, interactive media and web design.  {br} National Qualifications : Diploma in Visual Communication (SAQA ID: 94158, NQF 6, 360 Credits) International Qialifications : ACA Illustrator, ACA Photoshop, ACA Animate, ACA InDesign, ACA Premier Pro" },
                    {$"{br} Financial Accounting", $" {br} Purpose : This programme will provide you the knowledge and practical skills in bookkeeping, income tax, financial accounting, reporting standards, financial management, corporate strategy, management accounting and research.   National Qualifications : QCTO National Certificate: Bookkeeping (SAQA ID: 58375, NQF 3, 120 Credits), QCTO FET Certificate: Bookkeeping (SAQA ID: 58376, NQF 4, 130 Cumulative Credits), QCTO National Diploma: Technical Financial Accounting (SAQA ID: 36213, NQF 5, 251 Cumulative Credits), QCTO National Diploma: Financial Accounting (SAQA ID: 20366, NQF 6, 280 Cumulative Credits) Certificate issued by ICB {br} International Qualifications : Microsoft Office Word, Microsoft Office Excel  " }
                },
                CampusVideos = new Uri("ms-appx:///CampusAssets/CampusVideos/Auckland/Auckland.mp4"),
                CampusLocation = new Uri("ms-appx:///CampusAssets/CampusMaps/Auckland/Auckland.png"),
                CampusImage = new BitmapImage(new Uri("ms-appx:///CampusAssets/CampusImage/Auckland/AucklandShow.jpg")),
                MapLat = -26.184588,
                MapLong = 28.013505
            }
        };
    }
}
