﻿using Microsoft.EntityFrameworkCore;
using StudentRegister.Models.Entities;

namespace StudentRegister.DataAccess
{
    public class StudentRegisterContext : DbContext
    {
        public StudentRegisterContext(DbContextOptions<StudentRegisterContext> options) : base(options) { }

        public DbSet<Student> Students { get; set; }
        public DbSet<FamilyMember> FamilyMembers { get; set; }
        public DbSet<Nationality> Nationalities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Student>().HasOne(s => s.Nationality).WithOne().HasForeignKey<Student>(s => s.NationalityId).IsRequired(false);
            modelBuilder.Entity<FamilyMember>().HasOne(x => x.Student).WithMany(x => x.FamilyMembers).HasForeignKey(x => x.StudentID).OnDelete(DeleteBehavior.Restrict);

            InitianDataSeeding(modelBuilder);
        }

        private static void InitianDataSeeding(ModelBuilder modelBuilder)
        {
            List<Nationality> nationalities = new List<Nationality>
            {
                new Nationality{Id=1,Alpha2Code = "AF",Country = "Afghanistan",NationalityName = "Afghan"},
                new Nationality{Id=2,Alpha2Code = "AX",Country = "Åland Islands",NationalityName = "Åland Island"},
                new Nationality{Id=3,Alpha2Code = "AL",Country = "Albania",NationalityName = "Albanian"},
                new Nationality{Id=4,Alpha2Code = "DZ",Country = "Algeria",NationalityName = "Algerian"},
                new Nationality{Id=5,Alpha2Code = "AS",Country = "American Samoa",NationalityName = "American Samoan"},
                new Nationality{Id=6,Alpha2Code = "AD",Country = "Andorra",NationalityName = "Andorran"},
                new Nationality{Id=7,Alpha2Code = "AO",Country = "Angola",NationalityName = "Angolan"},
                new Nationality{Id=8,Alpha2Code = "AI",Country = "Anguilla",NationalityName = "Anguillan"},
                new Nationality{Id=9,Alpha2Code = "AQ",Country = "Antarctica",NationalityName = "Antarctic"},
                new Nationality{Id=10,Alpha2Code = "AG",Country = "Antigua and Barbuda",NationalityName = "Antiguan or Barbudan"},
                new Nationality{Id=11,Alpha2Code = "AR",Country = "Argentina",NationalityName = "Argentine"},
                new Nationality{Id=12,Alpha2Code = "AM",Country = "Armenia",NationalityName = "Armenian"},
                new Nationality{Id=13,Alpha2Code = "AW",Country = "Aruba",NationalityName = "Aruban"},
                new Nationality{Id=14,Alpha2Code = "AU",Country = "Australia",NationalityName = "Australian"},
                new Nationality{Id=15,Alpha2Code = "AT",Country = "Austria",NationalityName = "Austrian"},
                new Nationality{Id=16,Alpha2Code = "AZ",Country = "Azerbaijan",NationalityName = "Azerbaijani, Azeri"},
                new Nationality{Id=17,Alpha2Code = "BS",Country = "Bahamas",NationalityName = "Bahamian"},
                new Nationality{Id=18,Alpha2Code = "BH",Country = "Bahrain",NationalityName = "Bahraini"},
                new Nationality{Id=19,Alpha2Code = "BD",Country = "Bangladesh",NationalityName = "Bangladeshi"},
                new Nationality{Id=20,Alpha2Code = "BB",Country = "Barbados",NationalityName = "Barbadian"},
                new Nationality{Id=21,Alpha2Code = "BY",Country = "Belarus",NationalityName = "Belarusian"},
                new Nationality{Id=22,Alpha2Code = "BE",Country = "Belgium",NationalityName = "Belgian"},
                new Nationality{Id=23,Alpha2Code = "BZ",Country = "Belize",NationalityName = "Belizean"},
                new Nationality{Id=24,Alpha2Code = "BJ",Country = "Benin",NationalityName = "Beninese, Beninois"},
                new Nationality{Id=25,Alpha2Code = "BM",Country = "Bermuda",NationalityName = "Bermudian, Bermudan"},
                new Nationality{Id=26,Alpha2Code = "BT",Country = "Bhutan",NationalityName = "Bhutanese"},
                new Nationality{Id=27,Alpha2Code = "BO",Country = "Bolivia (Plurinational State of)",NationalityName = "Bolivian"},
                new Nationality{Id=28,Alpha2Code = "BQ",Country = "Bonaire, Sint Eustatius and Saba",NationalityName = "Bonaire"},
                new Nationality{Id=29,Alpha2Code = "BA",Country = "Bosnia and Herzegovina",NationalityName = "Bosnian or Herzegovinian"},
                new Nationality{Id=30,Alpha2Code = "BW",Country = "Botswana",NationalityName = "Motswana, Botswanan"},
                new Nationality{Id=31,Alpha2Code = "BV",Country = "Bouvet Island",NationalityName = "Bouvet Island"},
                new Nationality{Id=32,Alpha2Code = "BR",Country = "Brazil",NationalityName = "Brazilian"},
                new Nationality{Id=33,Alpha2Code = "IO",Country = "British Indian Ocean Territory",NationalityName = "BIOT"},
                new Nationality{Id=34,Alpha2Code = "BN",Country = "Brunei Darussalam",NationalityName = "Bruneian"},
                new Nationality{Id=35,Alpha2Code = "BG",Country = "Bulgaria",NationalityName = "Bulgarian"},
                new Nationality{Id=36,Alpha2Code = "BF",Country = "Burkina Faso",NationalityName = "Burkinabé"},
                new Nationality{Id=37,Alpha2Code = "BI",Country = "Burundi",NationalityName = "Burundian"},
                new Nationality{Id=38,Alpha2Code = "CV",Country = "Cabo Verde",NationalityName = "Cabo Verdean"},
                new Nationality{Id=39,Alpha2Code = "KH",Country = "Cambodia",NationalityName = "Cambodian"},
                new Nationality{Id=40,Alpha2Code = "CM",Country = "Cameroon",NationalityName = "Cameroonian"},
                new Nationality{Id=41,Alpha2Code = "CA",Country = "Canada",NationalityName = "Canadian"},
                new Nationality{Id=42,Alpha2Code = "KY",Country = "Cayman Islands",NationalityName = "Caymanian"},
                new Nationality{Id=43,Alpha2Code = "CF",Country = "Central African Republic",NationalityName = "Central African"},
                new Nationality{Id=44,Alpha2Code = "TD",Country = "Chad",NationalityName = "Chadian"},
                new Nationality{Id=45,Alpha2Code = "CL",Country = "Chile",NationalityName = "Chilean"},
                new Nationality{Id=46,Alpha2Code = "CN",Country = "China",NationalityName = "Chinese"},
                new Nationality{Id=47,Alpha2Code = "CX",Country = "Christmas Island",NationalityName = "Christmas Island"},
                new Nationality{Id=48,Alpha2Code = "CC",Country = "Cocos (Keeling) Islands",NationalityName = "Cocos Island"},
                new Nationality{Id=49,Alpha2Code = "CO",Country = "Colombia",NationalityName = "Colombian"},
                new Nationality{Id=50,Alpha2Code = "KM",Country = "Comoros",NationalityName = "Comoran, Comorian"},
                new Nationality{Id=51,Alpha2Code = "CG",Country = "Congo (Republic of the)",NationalityName = "Congolese"},
                new Nationality{Id=52,Alpha2Code = "CD",Country = "Congo (Democratic Republic of the)",NationalityName = "Congolese"},
                new Nationality{Id=53,Alpha2Code = "CK",Country = "Cook Islands",NationalityName = "Cook Island"},
                new Nationality{Id=54,Alpha2Code = "CR",Country = "Costa Rica",NationalityName = "Costa Rican"},
                new Nationality{Id=55,Alpha2Code = "CI",Country = "Côte d'Ivoire",NationalityName = "Ivorian"},
                new Nationality{Id=56,Alpha2Code = "HR",Country = "Croatia",NationalityName = "Croatian"},
                new Nationality{Id=57,Alpha2Code = "CU",Country = "Cuba",NationalityName = "Cuban"},
                new Nationality{Id=58,Alpha2Code = "CW",Country = "Curaçao",NationalityName = "Curaçaoan"},
                new Nationality{Id=59,Alpha2Code = "CY",Country = "Cyprus",NationalityName = "Cypriot"},
                new Nationality{Id=60,Alpha2Code = "CZ",Country = "Czech Republic",NationalityName = "Czech"},
                new Nationality{Id=61,Alpha2Code = "DK",Country = "Denmark",NationalityName = "Danish"},
                new Nationality{Id=62,Alpha2Code = "DJ",Country = "Djibouti",NationalityName = "Djiboutian"},
                new Nationality{Id=63,Alpha2Code = "DM",Country = "Dominica",NationalityName = "Dominican"},
                new Nationality{Id=64,Alpha2Code = "DO",Country = "Dominican Republic",NationalityName = "Dominican"},
                new Nationality{Id=65,Alpha2Code = "EC",Country = "Ecuador",NationalityName = "Ecuadorian"},
                new Nationality{Id=66,Alpha2Code = "EG",Country = "Egypt",NationalityName = "Egyptian"},
                new Nationality{Id=67,Alpha2Code = "SV",Country = "El Salvador",NationalityName = "Salvadoran"},
                new Nationality{Id=68,Alpha2Code = "GQ",Country = "Equatorial Guinea",NationalityName = "Equatorial Guinean, Equatoguinean"},
                new Nationality{Id=69,Alpha2Code = "ER",Country = "Eritrea",NationalityName = "Eritrean"},
                new Nationality{Id=70,Alpha2Code = "EE",Country = "Estonia",NationalityName = "Estonian"},
                new Nationality{Id=71,Alpha2Code = "ET",Country = "Ethiopia",NationalityName = "Ethiopian"},
                new Nationality{Id=72,Alpha2Code = "FK",Country = "Falkland Islands (Malvinas)",NationalityName = "Falkland Island"},
                new Nationality{Id=73,Alpha2Code = "FO",Country = "Faroe Islands",NationalityName = "Faroese"},
                new Nationality{Id=74,Alpha2Code = "FJ",Country = "Fiji",NationalityName = "Fijian"},
                new Nationality{Id=75,Alpha2Code = "FI",Country = "Finland",NationalityName = "Finnish"},
                new Nationality{Id=76,Alpha2Code = "FR",Country = "France",NationalityName = "French"},
                new Nationality{Id=77,Alpha2Code = "GF",Country = "French Guiana",NationalityName = "French Guianese"},
                new Nationality{Id=78,Alpha2Code = "PF",Country = "French Polynesia",NationalityName = "French Polynesian"},
                new Nationality{Id=79,Alpha2Code = "TF",Country = "French Southern Territories",NationalityName = "French Southern Territories"},
                new Nationality{Id=80,Alpha2Code = "GA",Country = "Gabon",NationalityName = "Gabonese"},
                new Nationality{Id=81,Alpha2Code = "GM",Country = "Gambia",NationalityName = "Gambian"},
                new Nationality{Id=82,Alpha2Code = "GE",Country = "Georgia",NationalityName = "Georgian"},
                new Nationality{Id=83,Alpha2Code = "DE",Country = "Germany",NationalityName = "German"},
                new Nationality{Id=84,Alpha2Code = "GH",Country = "Ghana",NationalityName = "Ghanaian"},
                new Nationality{Id=85,Alpha2Code = "GI",Country = "Gibraltar",NationalityName = "Gibraltar"},
                new Nationality{Id=86,Alpha2Code = "GR",Country = "Greece",NationalityName = "Greek, Hellenic"},
                new Nationality{Id=87,Alpha2Code = "GL",Country = "Greenland",NationalityName = "Greenlandic"},
                new Nationality{Id=88,Alpha2Code = "GD",Country = "Grenada",NationalityName = "Grenadian"},
                new Nationality{Id=89,Alpha2Code = "GP",Country = "Guadeloupe",NationalityName = "Guadeloupe"},
                new Nationality{Id=90,Alpha2Code = "GU",Country = "Guam",NationalityName = "Guamanian, Guambat"},
                new Nationality{Id=91,Alpha2Code = "GT",Country = "Guatemala",NationalityName = "Guatemalan"},
                new Nationality{Id=92,Alpha2Code = "GG",Country = "Guernsey",NationalityName = "Channel Island"},
                new Nationality{Id=93,Alpha2Code = "GN",Country = "Guinea",NationalityName = "Guinean"},
                new Nationality{Id=94,Alpha2Code = "GW",Country = "Guinea-Bissau",NationalityName = "Bissau-Guinean"},
                new Nationality{Id=95,Alpha2Code = "GY",Country = "Guyana",NationalityName = "Guyanese"},
                new Nationality{Id=96,Alpha2Code = "HT",Country = "Haiti",NationalityName = "Haitian"},
                new Nationality{Id=97,Alpha2Code = "HM",Country = "Heard Island and McDonald Islands",NationalityName = "Heard Island or McDonald Islands"},
                new Nationality{Id=98,Alpha2Code = "VA",Country = "Vatican City State",NationalityName = "Vatican"},
                new Nationality{Id=99,Alpha2Code = "HN",Country = "Honduras",NationalityName = "Honduran"},
                new Nationality{Id=100,Alpha2Code = "HK",Country = "Hong Kong",NationalityName = "Hong Kong, Hong Kongese"},
                new Nationality{Id=101,Alpha2Code = "HU",Country = "Hungary",NationalityName = "Hungarian, Magyar"},
                new Nationality{Id=102,Alpha2Code = "IS",Country = "Iceland",NationalityName = "Icelandic"},
                new Nationality{Id=103,Alpha2Code = "IN",Country = "India",NationalityName = "Indian"},
                new Nationality{Id=104,Alpha2Code = "ID",Country = "Indonesia",NationalityName = "Indonesian"},
                new Nationality{Id=105,Alpha2Code = "IR",Country = "Iran",NationalityName = "Iranian, Persian"},
                new Nationality{Id=106,Alpha2Code = "IQ",Country = "Iraq",NationalityName = "Iraqi"},
                new Nationality{Id=107,Alpha2Code = "IE",Country = "Ireland",NationalityName = "Irish"},
                new Nationality{Id=108,Alpha2Code = "IM",Country = "Isle of Man",NationalityName = "Manx"},
                new Nationality{Id=109,Alpha2Code = "IL",Country = "Israel",NationalityName = "Israeli"},
                new Nationality{Id=110,Alpha2Code = "IT",Country = "Italy",NationalityName = "Italian"},
                new Nationality{Id=111,Alpha2Code = "JM",Country = "Jamaica",NationalityName = "Jamaican"},
                new Nationality{Id=112,Alpha2Code = "JP",Country = "Japan",NationalityName = "Japanese"},
                new Nationality{Id=113,Alpha2Code = "JE",Country = "Jersey",NationalityName = "Channel Island"},
                new Nationality{Id=114,Alpha2Code = "JO",Country = "Jordan",NationalityName = "Jordanian"},
                new Nationality{Id=115,Alpha2Code = "KZ",Country = "Kazakhstan",NationalityName = "Kazakhstani, Kazakh"},
                new Nationality{Id=116,Alpha2Code = "KE",Country = "Kenya",NationalityName = "Kenyan"},
                new Nationality{Id=117,Alpha2Code = "KI",Country = "Kiribati",NationalityName = "I-Kiribati"},
                new Nationality{Id=118,Alpha2Code = "KP",Country = "Korea (Democratic People's Republic of)",NationalityName = "North Korean"},
                new Nationality{Id=119,Alpha2Code = "KR",Country = "Korea (Republic of)",NationalityName = "South Korean"},
                new Nationality{Id=120,Alpha2Code = "KW",Country = "Kuwait",NationalityName = "Kuwaiti"},
                new Nationality{Id=121,Alpha2Code = "KG",Country = "Kyrgyzstan",NationalityName = "Kyrgyzstani, Kyrgyz, Kirgiz, Kirghiz"},
                new Nationality{Id=122,Alpha2Code = "LA",Country = "Lao People's Democratic Republic",NationalityName = "Lao, Laotian"},
                new Nationality{Id=123,Alpha2Code = "LV",Country = "Latvia",NationalityName = "Latvian"},
                new Nationality{Id=124,Alpha2Code = "LB",Country = "Lebanon",NationalityName = "Lebanese"},
                new Nationality{Id=125,Alpha2Code = "LS",Country = "Lesotho",NationalityName = "Basotho"},
                new Nationality{Id=126,Alpha2Code = "LR",Country = "Liberia",NationalityName = "Liberian"},
                new Nationality{Id=127,Alpha2Code = "LY",Country = "Libya",NationalityName = "Libyan"},
                new Nationality{Id=128,Alpha2Code = "LI",Country = "Liechtenstein",NationalityName = "Liechtenstein"},
                new Nationality{Id=129,Alpha2Code = "LT",Country = "Lithuania",NationalityName = "Lithuanian"},
                new Nationality{Id=130,Alpha2Code = "LU",Country = "Luxembourg",NationalityName = "Luxembourg, Luxembourgish"},
                new Nationality{Id=131,Alpha2Code = "MO",Country = "Macao",NationalityName = "Macanese, Chinese"},
                new Nationality{Id=132,Alpha2Code = "MK",Country = "Macedonia (the former Yugoslav Republic of)",NationalityName = "Macedonian"},
                new Nationality{Id=133,Alpha2Code = "MG",Country = "Madagascar",NationalityName = "Malagasy"},
                new Nationality{Id=134,Alpha2Code = "MW",Country = "Malawi",NationalityName = "Malawian"},
                new Nationality{Id=135,Alpha2Code = "MY",Country = "Malaysia",NationalityName = "Malaysian"},
                new Nationality{Id=136,Alpha2Code = "MV",Country = "Maldives",NationalityName = "Maldivian"},
                new Nationality{Id=137,Alpha2Code = "ML",Country = "Mali",NationalityName = "Malian, Malinese"},
                new Nationality{Id=138,Alpha2Code = "MT",Country = "Malta",NationalityName = "Maltese"},
                new Nationality{Id=139,Alpha2Code = "MH",Country = "Marshall Islands",NationalityName = "Marshallese"},
                new Nationality{Id=140,Alpha2Code = "MQ",Country = "Martinique",NationalityName = "Martiniquais, Martinican"},
                new Nationality{Id=141,Alpha2Code = "MR",Country = "Mauritania",NationalityName = "Mauritanian"},
                new Nationality{Id=142,Alpha2Code = "MU",Country = "Mauritius",NationalityName = "Mauritian"},
                new Nationality{Id=143,Alpha2Code = "YT",Country = "Mayotte",NationalityName = "Mahoran"},
                new Nationality{Id=144,Alpha2Code = "MX",Country = "Mexico",NationalityName = "Mexican"},
                new Nationality{Id=145,Alpha2Code = "FM",Country = "Micronesia (Federated States of)",NationalityName = "Micronesian"},
                new Nationality{Id=146,Alpha2Code = "MD",Country = "Moldova (Republic of)",NationalityName = "Moldovan"},
                new Nationality{Id=147,Alpha2Code = "MC",Country = "Monaco",NationalityName = "Monégasque, Monacan"},
                new Nationality{Id=148,Alpha2Code = "MN",Country = "Mongolia",NationalityName = "Mongolian"},
                new Nationality{Id=149,Alpha2Code = "ME",Country = "Montenegro",NationalityName = "Montenegrin"},
                new Nationality{Id=150,Alpha2Code = "MS",Country = "Montserrat",NationalityName = "Montserratian"},
                new Nationality{Id=151,Alpha2Code = "MA",Country = "Morocco",NationalityName = "Moroccan"},
                new Nationality{Id=152,Alpha2Code = "MZ",Country = "Mozambique",NationalityName = "Mozambican"},
                new Nationality{Id=153,Alpha2Code = "MM",Country = "Myanmar",NationalityName = "Burmese"},
                new Nationality{Id=154,Alpha2Code = "NA",Country = "Namibia",NationalityName = "Namibian"},
                new Nationality{Id=155,Alpha2Code = "NR",Country = "Nauru",NationalityName = "Nauruan"},
                new Nationality{Id=156,Alpha2Code = "NP",Country = "Nepal",NationalityName = "Nepali, Nepalese"},
                new Nationality{Id=157,Alpha2Code = "NL",Country = "Netherlands",NationalityName = "Dutch, Netherlandic"},
                new Nationality{Id=158,Alpha2Code = "NC",Country = "New Caledonia",NationalityName = "New Caledonian"},
                new Nationality{Id=159,Alpha2Code = "NZ",Country = "New Zealand",NationalityName = "New Zealand, NZ"},
                new Nationality{Id=160,Alpha2Code = "NI",Country = "Nicaragua",NationalityName = "Nicaraguan"},
                new Nationality{Id=161,Alpha2Code = "NE",Country = "Niger",NationalityName = "Nigerien"},
                new Nationality{Id=162,Alpha2Code = "NG",Country = "Nigeria",NationalityName = "Nigerian"},
                new Nationality{Id=163,Alpha2Code = "NU",Country = "Niue",NationalityName = "Niuean"},
                new Nationality{Id=164,Alpha2Code = "NF",Country = "Norfolk Island",NationalityName = "Norfolk Island"},
                new Nationality{Id=165,Alpha2Code = "MP",Country = "Northern Mariana Islands",NationalityName = "Northern Marianan"},
                new Nationality{Id=166,Alpha2Code = "NO",Country = "Norway",NationalityName = "Norwegian"},
                new Nationality{Id=167,Alpha2Code = "OM",Country = "Oman",NationalityName = "Omani"},
                new Nationality{Id=168,Alpha2Code = "PK",Country = "Pakistan",NationalityName = "Pakistani"},
                new Nationality{Id=169,Alpha2Code = "PW",Country = "Palau",NationalityName = "Palauan"},
                new Nationality{Id=170,Alpha2Code = "PS",Country = "Palestine, State of",NationalityName = "Palestinian"},
                new Nationality{Id=171,Alpha2Code = "PA",Country = "Panama",NationalityName = "Panamanian"},
                new Nationality{Id=172,Alpha2Code = "PG",Country = "Papua New Guinea",NationalityName = "Papua New Guinean, Papuan"},
                new Nationality{Id=173,Alpha2Code = "PY",Country = "Paraguay",NationalityName = "Paraguayan"},
                new Nationality{Id=174,Alpha2Code = "PE",Country = "Peru",NationalityName = "Peruvian"},
                new Nationality{Id=175,Alpha2Code = "PH",Country = "Philippines",NationalityName = "Philippine, Filipino"},
                new Nationality{Id=176,Alpha2Code = "PN",Country = "Pitcairn",NationalityName = "Pitcairn Island"},
                new Nationality{Id=177,Alpha2Code = "PL",Country = "Poland",NationalityName = "Polish"},
                new Nationality{Id=178,Alpha2Code = "PT",Country = "Portugal",NationalityName = "Portuguese"},
                new Nationality{Id=179,Alpha2Code = "PR",Country = "Puerto Rico",NationalityName = "Puerto Rican"},
                new Nationality{Id=180,Alpha2Code = "QA",Country = "Qatar",NationalityName = "Qatari"},
                new Nationality{Id=181,Alpha2Code = "RE",Country = "Réunion",NationalityName = "Réunionese, Réunionnais"},
                new Nationality{Id=182,Alpha2Code = "RO",Country = "Romania",NationalityName = "Romanian"},
                new Nationality{Id=183,Alpha2Code = "RU",Country = "Russian Federation",NationalityName = "Russian"},
                new Nationality{Id=184,Alpha2Code = "RW",Country = "Rwanda",NationalityName = "Rwandan"},
                new Nationality{Id=185,Alpha2Code = "BL",Country = "Saint Barthélemy",NationalityName = "Barthélemois"},
                new Nationality{Id=186,Alpha2Code = "SH",Country = "Saint Helena, Ascension and Tristan da Cunha",NationalityName = "Saint Helenian"},
                new Nationality{Id=187,Alpha2Code = "KN",Country = "Saint Kitts and Nevis",NationalityName = "Kittitian or Nevisian"},
                new Nationality{Id=188,Alpha2Code = "LC",Country = "Saint Lucia",NationalityName = "Saint Lucian"},
                new Nationality{Id=189,Alpha2Code = "MF",Country = "Saint Martin (French part)",NationalityName = "Saint-Martinoise"},
                new Nationality{Id=190,Alpha2Code = "PM",Country = "Saint Pierre and Miquelon",NationalityName = "Saint-Pierrais or Miquelonnais"},
                new Nationality{Id=191,Alpha2Code = "VC",Country = "Saint Vincent and the Grenadines",NationalityName = "Saint Vincentian, Vincentian"},
                new Nationality{Id=192,Alpha2Code = "WS",Country = "Samoa",NationalityName = "Samoan"},
                new Nationality{Id=193,Alpha2Code = "SM",Country = "San Marino",NationalityName = "Sammarinese"},
                new Nationality{Id=194,Alpha2Code = "ST",Country = "Sao Tome and Principe",NationalityName = "São Toméan"},
                new Nationality{Id=195,Alpha2Code = "SA",Country = "Saudi Arabia",NationalityName = "Saudi, Saudi Arabian"},
                new Nationality{Id=196,Alpha2Code = "SN",Country = "Senegal",NationalityName = "Senegalese"},
                new Nationality{Id=197,Alpha2Code = "RS",Country = "Serbia",NationalityName = "Serbian"},
                new Nationality{Id=198,Alpha2Code = "SC",Country = "Seychelles",NationalityName = "Seychellois"},
                new Nationality{Id=199,Alpha2Code = "SL",Country = "Sierra Leone",NationalityName = "Sierra Leonean"},
                new Nationality{Id=200,Alpha2Code = "SG",Country = "Singapore",NationalityName = "Singaporean"},
                new Nationality{Id=201,Alpha2Code = "SX",Country = "Sint Maarten (Dutch part)",NationalityName = "Sint Maarten"},
                new Nationality{Id=202,Alpha2Code = "SK",Country = "Slovakia",NationalityName = "Slovak"},
                new Nationality{Id=203,Alpha2Code = "SI",Country = "Slovenia",NationalityName = "Slovenian, Slovene"},
                new Nationality{Id=204,Alpha2Code = "SB",Country = "Solomon Islands",NationalityName = "Solomon Island"},
                new Nationality{Id=205,Alpha2Code = "SO",Country = "Somalia",NationalityName = "Somali, Somalian"},
                new Nationality{Id=206,Alpha2Code = "ZA",Country = "South Africa",NationalityName = "South African"},
                new Nationality{Id=207,Alpha2Code = "GS",Country = "South Georgia and the South Sandwich Islands",NationalityName = "South Georgia or South Sandwich Islands"},
                new Nationality{Id=208,Alpha2Code = "SS",Country = "South Sudan",NationalityName = "South Sudanese"},
                new Nationality{Id=209,Alpha2Code = "ES",Country = "Spain",NationalityName = "Spanish"},
                new Nationality{Id=210,Alpha2Code = "LK",Country = "Sri Lanka",NationalityName = "Sri Lankan"},
                new Nationality{Id=211,Alpha2Code = "SD",Country = "Sudan",NationalityName = "Sudanese"},
                new Nationality{Id=212,Alpha2Code = "SR",Country = "Suriname",NationalityName = "Surinamese"},
                new Nationality{Id=213,Alpha2Code = "SJ",Country = "Svalbard and Jan Mayen",NationalityName = "Svalbard"},
                new Nationality{Id=214,Alpha2Code = "SZ",Country = "Swaziland",NationalityName = "Swazi"},
                new Nationality{Id=215,Alpha2Code = "SE",Country = "Sweden",NationalityName = "Swedish"},
                new Nationality{Id=216,Alpha2Code = "CH",Country = "Switzerland",NationalityName = "Swiss"},
                new Nationality{Id=217,Alpha2Code = "SY",Country = "Syrian Arab Republic",NationalityName = "Syrian"},
                new Nationality{Id=218,Alpha2Code = "TW",Country = "Taiwan, Province of China",NationalityName = "Chinese, Taiwanese"},
                new Nationality{Id=219,Alpha2Code = "TJ",Country = "Tajikistan",NationalityName = "Tajikistani"},
                new Nationality{Id=220,Alpha2Code = "TZ",Country = "Tanzania, United Republic of",NationalityName = "Tanzanian"},
                new Nationality{Id=221,Alpha2Code = "TH",Country = "Thailand",NationalityName = "Thai"},
                new Nationality{Id=222,Alpha2Code = "TL",Country = "Timor-Leste",NationalityName = "Timorese"},
                new Nationality{Id=223,Alpha2Code = "TG",Country = "Togo",NationalityName = "Togolese"},
                new Nationality{Id=224,Alpha2Code = "TK",Country = "Tokelau",NationalityName = "Tokelauan"},
                new Nationality{Id=225,Alpha2Code = "TO",Country = "Tonga",NationalityName = "Tongan"},
                new Nationality{Id=226,Alpha2Code = "TT",Country = "Trinidad and Tobago",NationalityName = "Trinidadian or Tobagonian"},
                new Nationality{Id=227,Alpha2Code = "TN",Country = "Tunisia",NationalityName = "Tunisian"},
                new Nationality{Id=228,Alpha2Code = "TR",Country = "Turkey",NationalityName = "Turkish"},
                new Nationality{Id=229,Alpha2Code = "TM",Country = "Turkmenistan",NationalityName = "Turkmen"},
                new Nationality{Id=230,Alpha2Code = "TC",Country = "Turks and Caicos Islands",NationalityName = "Turks and Caicos Island"},
                new Nationality{Id=231,Alpha2Code = "TV",Country = "Tuvalu",NationalityName = "Tuvaluan"},
                new Nationality{Id=232,Alpha2Code = "UG",Country = "Uganda",NationalityName = "Ugandan"},
                new Nationality{Id=233,Alpha2Code = "UA",Country = "Ukraine",NationalityName = "Ukrainian"},
                new Nationality{Id=234,Alpha2Code = "AE",Country = "United Arab Emirates",NationalityName = "Emirati, Emirian, Emiri"},
                new Nationality{Id=235,Alpha2Code = "GB",Country = "United Kingdom of Great Britain and Northern Ireland",NationalityName = "British, UK"},
                new Nationality{Id=236,Alpha2Code = "UM",Country = "United States Minor Outlying Islands",NationalityName = "American"},
                new Nationality{Id=237,Alpha2Code = "US",Country = "United States of America",NationalityName = "American"},
                new Nationality{Id=238,Alpha2Code = "UY",Country = "Uruguay",NationalityName = "Uruguayan"},
                new Nationality{Id=239,Alpha2Code = "UZ",Country = "Uzbekistan",NationalityName = "Uzbekistani, Uzbek"},
                new Nationality{Id=240,Alpha2Code = "VU",Country = "Vanuatu",NationalityName = "Ni-Vanuatu, Vanuatuan"},
                new Nationality{Id=241,Alpha2Code = "VE",Country = "Venezuela (Bolivarian Republic of)",NationalityName = "Venezuelan"},
                new Nationality{Id=242,Alpha2Code = "VN",Country = "Vietnam",NationalityName = "Vietnamese"},
                new Nationality{Id=243,Alpha2Code = "VG",Country = "Virgin Islands (British)",NationalityName = "British Virgin Island"},
                new Nationality{Id=244,Alpha2Code = "VI",Country = "Virgin Islands (U.S.)",NationalityName = "U.S. Virgin Island"},
                new Nationality{Id=245,Alpha2Code = "WF",Country = "Wallis and Futuna",NationalityName = "Wallis and Futuna, Wallisian or Futunan"},
                new Nationality{Id=246,Alpha2Code = "EH",Country = "Western Sahara",NationalityName = "Sahrawi, Sahrawian, Sahraouian"},
                new Nationality{Id=247,Alpha2Code = "YE",Country = "Yemen",NationalityName = "Yemeni"},
                new Nationality{Id=248,Alpha2Code = "ZM",Country = "Zambia",NationalityName = "Zambian"},
                new Nationality{Id=249,Alpha2Code = "ZW",Country = "Zimbabwe",NationalityName = "Zimbabwean"}
            };

            modelBuilder.Entity<Nationality>().HasData(nationalities);
        }

    }
}
