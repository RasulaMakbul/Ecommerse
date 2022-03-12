using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ecommerse.Server.Migrations
{
    public partial class ProductSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "products",
                columns: new[] { "id", "ImageUrl", "Price", "description", "title" },
                values: new object[] { 1, "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg", 9.99m, "The Hitchhiker's Guide to the Galaxy[note 1] (sometimes referred to as HG2G,[1] HHGTTG,[2] H2G2,[3] or tHGttG) is a comedy science fiction franchise created by Douglas Adams. Originally a 1978 radio comedy broadcast on BBC Radio 4, it was later adapted to other formats, including stage shows, novels, comic books, a 1981 TV series, a 1984 text-based computer game, and 2005 feature film.The Hitchhiker's Guide to the Galaxy has become an international multi-media phenomenon; the novels are the most widely distributed, having been translated into more than 30 languages by 2005.[4][5] The first novel, The Hitchhiker's Guide to the Galaxy (1979), has been ranked fourth on the BBC’s The Big Read poll.[6] The sixth novel, And Another Thing, was written by Eoin Colfer with additional unpublished material by Douglas Adams. In 2017, BBC Radio 4 announced a 40th-anniversary celebration with Dirk Maggs, one of the original producers, in charge.[7] The first of six new episodes was broadcast on 8 March 2018.[8]The broad narrative of Hitchhiker follows the misadventures of the last surviving man, Arthur Dent, following the demolition of the Earth by a Vogon constructor fleet to make way for a hyperspace bypass. Dent is rescued from Earth's destruction by Ford Prefect—a human-like alien writer for the eccentric, electronic travel guide The Hitchhiker's Guide to the Galaxy—by hitchhiking onto a passing Vogon spacecraft. Following his rescue, Dent explores the galaxy with Prefect and encounters Trillian, another human who had been taken from Earth (before its destruction) by the two-headed President of the Galaxy Zaphod Beeblebrox and the depressed Marvin, the Paranoid Android. Certain narrative details were changed among the various adaptations.", "The Hitchhiker's Guide to the Galaxy" });

            migrationBuilder.InsertData(
                table: "products",
                columns: new[] { "id", "ImageUrl", "Price", "description", "title" },
                values: new object[] { 2, "https://upload.wikimedia.org/wikipedia/en/thumb/a/a4/Ready_Player_One_cover.jpg/220px-Ready_Player_One_cover.jpg", 7.99m, "Ready Player One is a 2011 science fiction novel, and the debut novel of American author Ernest Cline. The story, set in a dystopia in 2045, follows protagonist Wade Watts on his search for an Easter egg in a worldwide virtual reality game, the discovery of which would lead him to inherit the game creator's fortune. Cline sold the rights to publish the novel in June 2010, in a bidding war to the Crown Publishing Group (a division of Random House).[1] The book was published on August 16, 2011.[2] An audiobook was released the same day; it was narrated by Wil Wheaton, who was mentioned briefly in one of the chapters.[3][4]Ch. 20 In 2012, the book received an Alex Award from the Young Adult Library Services Association division of the American Library Association[5] and won the 2011 Prometheus Award.[6]A film adaptation, screenwritten by Cline and Zak Penn and directed by Steven Spielberg, was released on March 29, 2018. A sequel novel, Ready Player Two, was released on November 24, 2020, although to a less positive reception compared to its predecessor.", "Ready Player One" });

            migrationBuilder.InsertData(
                table: "products",
                columns: new[] { "id", "ImageUrl", "Price", "description", "title" },
                values: new object[] { 3, "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c3/1984first.jpg/220px-1984first.jpg", 6.99m, "Nineteen Eighty-Four (also stylised as 1984) is a dystopian social science fiction novel and cautionary tale written by English writer George Orwell. It was published on 8 June 1949 by Secker & Warburg as Orwell's ninth and final book completed in his lifetime. Thematically, it centres on the consequences of totalitarianism, mass surveillance and repressive regimentation of people and behaviours within society.[2][3] Orwell, a democratic socialist, modelled the totalitarian government in the novel after Stalinist Russia and Nazi Germany.[2][3][4] More broadly, the novel examines the role of truth and facts within politics and the ways in which they are manipulated.The story takes place in an imagined future, the year 1984, when much of the world has fallen victim to perpetual war, omnipresent government surveillance, historical negationism, and propaganda. Great Britain, known as Airstrip One, has become a province of the totalitarian superstate Oceania, ruled by the Party, who employ the Thought Police to persecute individuality and independent thinking.[5] Big Brother, the dictatorial leader of Oceania, enjoys an intense cult of personality, manufactured by the party's excessive brainwashing techniques. The protagonist, Winston Smith, is a diligent and skillful rank-and-file worker and Outer Party member who secretly hates the Party and dreams of rebellion. He enters into a forbidden relationship with his colleague Julia and starts to remember what life was like before the Party came to power.Nineteen Eighty-Four has become a classic literary example of political and dystopian fiction. It also popularised the term Orwellian as an adjective, with many terms used in the novel entering common usage, including Big Brother, doublethink, Thought Police, thoughtcrime, Newspeak, and 2 + 2 = 5. Parallels have been drawn between the novel's subject matter and real life instances of totalitarianism, mass surveillance, and violations of freedom of expression among other themes.[6][7][8] Time included the novel on its list of the 100 best English-language novels from 1923 to 2005,[9] and it was placed on the Modern Library's 100 Best Novels list, reaching number 13 on the editors' list and number 6 on the readers' list.[10] In 2003, it was listed at number eight on The Big Read survey by the BBC.", "Nineteen Eighty-Four" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 3);
        }
    }
}
