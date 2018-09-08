using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Services
{
    public class DrugService : IDrugService
    {
        IList<Drug> _drugs;
        public DrugService()
        {
            _drugs = new List<Drug>() {
                new Drug() {
                    id =  1,
                    CreateDate = "Tue Feb 03 2004 22:51:33 GMT+0000 (UTC)",
                    CompanyID =  63,
                    GenericName = "Actemra"
                },
                new Drug() {
                    id =  2,
                    CreateDate = "Thu Oct 13 1983 22:33:48 GMT+0000 (UTC)",
                    CompanyID =  50,
                    GenericName = "Benicar"
                },
                new Drug() {
                    id =  3,
                    CreateDate = "Sun Mar 07 2004 06:56:17 GMT+0000 (UTC)",
                    CompanyID =  14,
                    GenericName = "Biogesic"
                },
                new Drug() {
                    id =  4,
                    CreateDate = "Fri Jul 28 1972 05:58:54 GMT+0000 (UTC)",
                    CompanyID =  50,
                    GenericName = "Cheratussin AC"
                },
                new Drug() {
                    id =  5,
                    CreateDate = "Sat Jul 05 1986 08:41:01 GMT+0000 (UTC)",
                    CompanyID =  9,
                    GenericName = "Enalapril"
                },
                new Drug() {
                    id =  6,
                    CreateDate = "Thu Dec 19 1991 19:52:14 GMT+0000 (UTC)",
                    CompanyID =  4,
                    GenericName = "Maleate"
                },
                new Drug() {
                    id =  7,
                    CreateDate = "Tue Aug 02 2005 22:27:07 GMT+0000 (UTC)",
                    CompanyID =  24,
                    GenericName = "Endocet"
                },
                new Drug() {
                    id =  8,
                    CreateDate = "Sat Sep 02 2017 19:34:24 GMT+0000 (UTC)",
                    CompanyID =  14,
                    GenericName = "Famotidine"
                },
                new Drug() {
                    id =  9,
                    CreateDate = "Tue Jul 05 2016 18:12:42 GMT+0000 (UTC)",
                    CompanyID =  14,
                    GenericName = "Levaquin"
                },
                new Drug() {
                    id =  10,
                    CreateDate = "Thu Jan 07 2016 13:34:12 GMT+0000 (UTC)",
                    CompanyID =  9,
                    GenericName = "Lexapro"
                },
                new Drug() {
                    id =  11,
                    CreateDate = "Thu Sep 17 1981 13:06:09 GMT+0000 (UTC)",
                    CompanyID =  25,
                    GenericName = "Meloxicam"
                },
                new Drug() {
                    id =  12,
                    CreateDate = "Sat Jun 25 2011 00:12:54 GMT+0000 (UTC)",
                    CompanyID =  30,
                    GenericName = "Morix"
                },
                new Drug() {
                    id =  13,
                    CreateDate = "Sat Oct 22 1977 18:02:04 GMT+0000 (UTC)",
                    CompanyID =  24,
                    GenericName = "Naproxen"
                },
                new Drug() {
                    id =  14,
                    CreateDate = "Tue Apr 12 2016 03:14:15 GMT+0000 (UTC)",
                    CompanyID =  56,
                    GenericName = "Nexium"
                },
                new Drug() {
                    id =  15,
                    CreateDate = "Sat Jan 21 1995 08:05:07 GMT+0000 (UTC)",
                    CompanyID =  64,
                    GenericName = "Niaspan"
                },
                new Drug() {
                    id =  16,
                    CreateDate = "Sat Nov 06 1982 14:20:57 GMT+0000 (UTC)",
                    CompanyID =  4,
                    GenericName = "Oxycodone"
                },
                new Drug() {
                    id =  17,
                    CreateDate = "Mon Aug 03 2015 10:28:12 GMT+0000 (UTC)",
                    CompanyID =  14,
                    GenericName = "Penicillin VK"
                },
                new Drug() {
                    id =  18,
                    CreateDate = "Sat Mar 11 1995 04:29:06 GMT+0000 (UTC)",
                    CompanyID =  36,
                    GenericName = "Perjeta"
                },
                new Drug() {
                    id =  19,
                    CreateDate = "Tue Dec 07 1999 00:33:42 GMT+0000 (UTC)",
                    CompanyID =  50,
                    GenericName = "Oxycontin"
                },
                new Drug() {
                    id =  20,
                    CreateDate = "Sun Feb 08 1981 22:42:25 GMT+0000 (UTC)",
                    CompanyID =  59,
                    GenericName = "Rituxuan"
                },
                new Drug() {
                    id =  21,
                    CreateDate = "Sat Oct 07 1995 07:41:42 GMT+0000 (UTC)",
                    CompanyID =  70,
                    GenericName = "Seroquel"
                },
                new Drug() {
                    id =  22,
                    CreateDate = "Wed Jan 11 1984 05:50:24 GMT+0000 (UTC)",
                    CompanyID =  14,
                    GenericName = "Premarin"
                },
                new Drug() {
                    id =  23,
                    CreateDate = "Sat Jul 04 1998 02:01:20 GMT+0000 (UTC)",
                    CompanyID =  14,
                    GenericName = "Sulfamethoxazole/Trimethoprim"
                },
                new Drug() {
                    id =  24,
                    CreateDate = "Thu Jun 28 1990 10:53:01 GMT+0000 (UTC)",
                    CompanyID =  60,
                    GenericName = "Symbicort"
                },
                new Drug() {
                    id =  25,
                    CreateDate = "Mon Jun 30 1986 03:24:36 GMT+0000 (UTC)",
                    CompanyID =  27,
                    GenericName = "Triamcinolone Acetonide"
                },
                new Drug() {
                    id =  26,
                    CreateDate = "Thu Oct 22 1981 22:40:22 GMT+0000 (UTC)",
                    CompanyID =  30,
                    GenericName = "Spiriva Handihaler"
                },
                new Drug() {
                    id =  27,
                    CreateDate = "Mon Dec 20 1993 07:50:51 GMT+0000 (UTC)",
                    CompanyID =  11,
                    GenericName = "Suboxone"
                },
                new Drug() {
                    id =  28,
                    CreateDate = "Wed Jun 22 1983 23:01:24 GMT+0000 (UTC)",
                    CompanyID =  21,
                    GenericName = "Trazodone HCl"
                },
                new Drug() {
                    id =  29,
                    CreateDate = "Sat Jun 16 1984 06:01:03 GMT+0000 (UTC)",
                    CompanyID =  39,
                    GenericName = "Venlafaxine HCl ER"
                },
                new Drug() {
                    id =  30,
                    CreateDate = "Wed Dec 18 2013 22:26:37 GMT+0000 (UTC)",
                    CompanyID =  7,
                    GenericName = "Ventolin HFA"
                },
                new Drug() {
                    id =  31,
                    CreateDate = "Tue Apr 23 1974 05:37:43 GMT+0000 (UTC)",
                    CompanyID =  8,
                    GenericName = "Kadcyla"
                },
                new Drug() {
                    id =  32,
                    CreateDate = "Sun Dec 13 1970 20:10:03 GMT+0000 (UTC)",
                    CompanyID =  46,
                    GenericName = "Vytorin"
                },
                new Drug() {
                    id =  33,
                    CreateDate = "Sun Oct 19 1980 10:29:31 GMT+0000 (UTC)",
                    CompanyID =  53,
                    GenericName = "Zetia"
                },
                new Drug() {
                    id =  34,
                    CreateDate = "Sun Jan 19 1992 11:32:03 GMT+0000 (UTC)",
                    CompanyID =  63,
                    GenericName = "Synthroid"
                },
                new Drug() {
                    id =  35,
                    CreateDate = "Sun Jan 31 1971 21:55:11 GMT+0000 (UTC)",
                    CompanyID =  34,
                    GenericName = "Ranitidine HCl"
                },
                new Drug() {
                    id =  36,
                    CreateDate = "Thu Jan 17 1985 05:24:28 GMT+0000 (UTC)",
                    CompanyID =  5,
                    GenericName = "Metoprolol Succinate"
                },
                new Drug() {
                    id =  37,
                    CreateDate = "Thu Jan 23 2003 03:49:08 GMT+0000 (UTC)",
                    CompanyID =  50,
                    GenericName = "Lantus Solostar"
                },
                new Drug() {
                    id =  38,
                    CreateDate = "Sun Feb 15 2004 11:26:10 GMT+0000 (UTC)",
                    CompanyID =  22,
                    GenericName = "Lipitor"
                },
                new Drug() {
                    id =  39,
                    CreateDate = "Sun Dec 04 1994 11:06:46 GMT+0000 (UTC)",
                    CompanyID =  1,
                    GenericName = "Lisinopril/Hydrochlorothiazide"
                },
                new Drug() {
                    id =  40,
                    CreateDate = "Fri Apr 13 2018 16:18:41 GMT+0000 (UTC)",
                    CompanyID =  37,
                    GenericName = "Lovastatin"
                },
                new Drug() {
                    id =  41,
                    CreateDate = "Sun Mar 26 1972 01:25:50 GMT+0000 (UTC)",
                    CompanyID =  40,
                    GenericName = "Fluconazole"
                },
                new Drug() {
                    id =  42,
                    CreateDate = "Fri Oct 22 2004 17:18:16 GMT+0000 (UTC)",
                    CompanyID =  7,
                    GenericName = "Fluoxetine HCl"
                },
                new Drug() {
                    id =  43,
                    CreateDate = "Wed Feb 01 2017 00:40:19 GMT+0000 (UTC)",
                    CompanyID =  13,
                    GenericName = "Glipizide"
                },
                new Drug() {
                    id =  44,
                    CreateDate = "Thu Jul 24 2003 07:56:13 GMT+0000 (UTC)",
                    CompanyID =  3,
                    GenericName = "Carisoprodol"
                },
                new Drug() {
                    id =  45,
                    CreateDate = "Tue Feb 28 1989 11:04:52 GMT+0000 (UTC)",
                    CompanyID =  12,
                    GenericName = "Celebrex"
                },
                new Drug() {
                    id =  46,
                    CreateDate = "Tue Apr 24 1990 14:54:30 GMT+0000 (UTC)",
                    CompanyID =  47,
                    GenericName = "Clindamycin HCl"
                },
                new Drug() {
                    id =  47,
                    CreateDate = "Wed Feb 17 2016 01:10:21 GMT+0000 (UTC)",
                    CompanyID =  54,
                    GenericName = "Crestor"
                },
                new Drug() {
                    id =  48,
                    CreateDate = "Thu May 24 2018 22:06:45 GMT+0000 (UTC)",
                    CompanyID =  55,
                    GenericName = "Cymbalta"
                },
                new Drug() {
                    id =  49,
                    CreateDate = "Mon Apr 27 1970 03:29:08 GMT+0000 (UTC)",
                    CompanyID =  8,
                    GenericName = "Allopurinol"
                },
                new Drug() {
                    id =  50,
                    CreateDate = "Wed May 28 2003 10:30:43 GMT+0000 (UTC)",
                    CompanyID =  26,
                    GenericName = "Bystolic"
                },
                new Drug() {
                    id =  51,
                    CreateDate = "Fri Dec 18 1987 16:32:00 GMT+0000 (UTC)",
                    CompanyID =  62,
                    GenericName = "APAP/Codeine"
                },
                new Drug() {
                    id =  52,
                    CreateDate = "Fri Jul 18 1997 05:45:52 GMT+0000 (UTC)",
                    CompanyID =  52,
                    GenericName = "Atenolol"
                },
                new Drug() {
                    id =  53,
                    CreateDate = "Sun Aug 07 2016 02:32:54 GMT+0000 (UTC)",
                    CompanyID =  68,
                    GenericName = "Diazepam"
                },
                new Drug() {
                    id =  54,
                    CreateDate = "Tue Jun 06 1995 02:13:49 GMT+0000 (UTC)",
                    CompanyID =  2,
                    GenericName = "Cialis"
                },
                new Drug() {
                    id =  55,
                    CreateDate = "Fri Dec 15 1972 00:24:57 GMT+0000 (UTC)",
                    CompanyID =  2,
                    GenericName = "Glyburide"
                },
                new Drug() {
                    id =  56,
                    CreateDate = "Sat Feb 22 1986 04:32:30 GMT+0000 (UTC)",
                    CompanyID =  40,
                    GenericName = "Folic Acid"
                },
                new Drug() {
                    id =  57,
                    CreateDate = "Fri Dec 16 1994 14:37:51 GMT+0000 (UTC)",
                    CompanyID =  20,
                    GenericName = "Flovent HFA"
                },
                new Drug() {
                    id =  58,
                    CreateDate = "Tue Apr 08 2008 02:35:35 GMT+0000 (UTC)",
                    CompanyID =  51,
                    GenericName = "Lantus"
                },
                new Drug() {
                    id =  59,
                    CreateDate = "Sun May 09 2010 00:29:28 GMT+0000 (UTC)",
                    CompanyID =  41,
                    GenericName = "Lidoderm"
                },
                new Drug() {
                    id =  60,
                    CreateDate = "Fri Oct 27 1972 07:45:41 GMT+0000 (UTC)",
                    CompanyID =  36,
                    GenericName = "Levothyroxine Sodium"
                },
                new Drug() {
                    id =  61,
                    CreateDate = "Tue Dec 17 1996 10:34:07 GMT+0000 (UTC)",
                    CompanyID =  24,
                    GenericName = "Metoprolol Succinatee"
                },
                new Drug() {
                    id =  62,
                    CreateDate = "Mon Nov 28 2016 21:38:21 GMT+0000 (UTC)",
                    CompanyID =  37,
                    GenericName = "Oxycodone HCl"
                },
                new Drug() {
                    id =  63,
                    CreateDate = "Sun Nov 14 1999 11:20:55 GMT+0000 (UTC)",
                    CompanyID =  63,
                    GenericName = "Nuvaring"
                },
                new Drug() {
                    id =  64,
                    CreateDate = "Sat Oct 28 1972 00:51:32 GMT+0000 (UTC)",
                    CompanyID =  51,
                    GenericName = "Lyrica"
                },
                new Drug() {
                    id =  65,
                    CreateDate = "Wed Oct 15 1986 13:33:52 GMT+0000 (UTC)",
                    CompanyID =  50,
                    GenericName = "Tamsulosin HCl"
                },
                new Drug() {
                    id =  66,
                    CreateDate = "Thu Sep 14 1978 18:48:21 GMT+0000 (UTC)",
                    CompanyID =  63,
                    GenericName = "Pantoprazole Sodium"
                },
                new Drug() {
                    id =  67,
                    CreateDate = "Fri Dec 18 1987 01:36:07 GMT+0000 (UTC)",
                    CompanyID =  36,
                    GenericName = "Pravastatin Sodium"
                },
                new Drug() {
                    id =  68,
                    CreateDate = "Sun May 29 1988 02:55:18 GMT+0000 (UTC)",
                    CompanyID =  57,
                    GenericName = "Vyvanse"
                },
                new Drug() {
                    id =  69,
                    CreateDate = "Sun Apr 19 1987 03:52:18 GMT+0000 (UTC)",
                    CompanyID =  46,
                    GenericName = "Vitamin D (Rx)"
                },
                new Drug() {
                    id =  70,
                    CreateDate = "Thu Jun 29 1989 22:17:01 GMT+0000 (UTC)",
                    CompanyID =  38,
                    GenericName = "Tri-Sprintec"
                },
                new Drug() {
                    id =  71,
                    CreateDate = "Tue Dec 24 2002 01:07:38 GMT+0000 (UTC)",
                    CompanyID =  49,
                    GenericName = "Triamterene/Hydrochlorothiazide"
                },
                new Drug() {
                    id =  72,
                    CreateDate = "Thu Oct 20 2005 04:19:04 GMT+0000 (UTC)",
                    CompanyID =  66,
                    GenericName = "Tricor"
                },
                new Drug() {
                    id =  73,
                    CreateDate = "Wed Apr 20 2011 18:30:27 GMT+0000 (UTC)",
                    CompanyID =  58,
                    GenericName = "TriNessa"
                },
                new Drug() {
                    id =  74,
                    CreateDate = "Thu Oct 24 2002 18:42:37 GMT+0000 (UTC)",
                    CompanyID =  48,
                    GenericName = "Warfarin Sodium"
                },
                new Drug() {
                    id =  75,
                    CreateDate = "Tue May 25 1982 10:30:15 GMT+0000 (UTC)",
                    CompanyID =  27,
                    GenericName = "Paroxetine HCl"
                },
                new Drug() {
                    id =  76,
                    CreateDate = "Sun Jul 08 2007 12:59:13 GMT+0000 (UTC)",
                    CompanyID =  59,
                    GenericName = "Singulair"
                },
                new Drug() {
                    id =  77,
                    CreateDate = "Fri Oct 20 1989 23:19:08 GMT+0000 (UTC)",
                    CompanyID =  63,
                    GenericName = "Methylprednisolone"
                },
                new Drug() {
                    id =  78,
                    CreateDate = "Wed Jul 08 2009 06:34:22 GMT+0000 (UTC)",
                    CompanyID =  18,
                    GenericName = "Oxycodone/APAP"
                },
                new Drug() {
                    id =  79,
                    CreateDate = "Wed Apr 29 1987 06:42:37 GMT+0000 (UTC)",
                    CompanyID =  41,
                    GenericName = "Metoprolol Tartrate "
                },
                new Drug() {
                    id =  80,
                    CreateDate = "Tue Apr 15 2008 19:32:16 GMT+0000 (UTC)",
                    CompanyID =  17,
                    GenericName = "Januvia"
                },
                new Drug() {
                    id =  81,
                    CreateDate = "Tue Jun 02 1998 16:32:44 GMT+0000 (UTC)",
                    CompanyID =  19,
                    GenericName = "Lovaza"
                },
                new Drug() {
                    id =  82,
                    CreateDate = "Sat Feb 14 2009 15:19:47 GMT+0000 (UTC)",
                    CompanyID =  53,
                    GenericName = "Levoxyl"
                },
                new Drug() {
                    id =  83,
                    CreateDate = "Fri Feb 09 1990 13:00:04 GMT+0000 (UTC)",
                    CompanyID =  46,
                    GenericName = "Losartan Potassium"
                },
                new Drug() {
                    id =  84,
                    CreateDate = "Mon Jun 23 2008 21:47:09 GMT+0000 (UTC)",
                    CompanyID =  22,
                    GenericName = "Diovan HCT"
                },
                new Drug() {
                    id =  85,
                    CreateDate = "Thu Mar 22 2001 13:09:23 GMT+0000 (UTC)",
                    CompanyID =  25,
                    GenericName = "Doxycycline Hyclate"
                },
                new Drug() {
                    id =  86,
                    CreateDate = "Tue Dec 16 1980 21:21:58 GMT+0000 (UTC)",
                    CompanyID =  52,
                    GenericName = "Amphetamine Salts"
                },
                new Drug() {
                    id =  87,
                    CreateDate = "Fri Dec 11 1981 03:13:56 GMT+0000 (UTC)",
                    CompanyID =  68,
                    GenericName = "Hydrochlorothiazide"
                },
                new Drug() {
                    id =  88,
                    CreateDate = "Tue Apr 09 1985 02:25:22 GMT+0000 (UTC)",
                    CompanyID =  23,
                    GenericName = "Ciprofloxacin HCl"
                },
                new Drug() {
                    id =  89,
                    CreateDate = "Tue Sep 04 2001 15:33:21 GMT+0000 (UTC)",
                    CompanyID =  22,
                    GenericName = "Cephalexin"
                },
                new Drug() {
                    id =  90,
                    CreateDate = "Fri Jul 25 1997 02:06:35 GMT+0000 (UTC)",
                    CompanyID =  69,
                    GenericName = "Cyclobenzaprin HCl"
                },
                new Drug() {
                    id =  91,
                    CreateDate = "Sat Dec 27 2003 15:55:34 GMT+0000 (UTC)",
                    CompanyID =  32,
                    GenericName = "Benicar HCT"
                },
                new Drug() {
                    id =  92,
                    CreateDate = "Sun Jun 16 1985 00:29:39 GMT+0000 (UTC)",
                    CompanyID =  46,
                    GenericName = "Advair Diskus"
                },
                new Drug() {
                    id =  93,
                    CreateDate = "Mon Sep 18 1995 01:35:40 GMT+0000 (UTC)",
                    CompanyID =  9,
                    GenericName = "Albuterol"
                },
                new Drug() {
                    id =  94,
                    CreateDate = "Sat Aug 31 2002 14:36:48 GMT+0000 (UTC)",
                    CompanyID =  70,
                    GenericName = "Alendronate Sodium"
                },
                new Drug() {
                    id =  95,
                    CreateDate = "Tue May 19 2015 06:06:44 GMT+0000 (UTC)",
                    CompanyID =  70,
                    GenericName = "Actos"
                },
                new Drug() {
                    id =  96,
                    CreateDate = "Sun Jul 18 2004 01:12:00 GMT+0000 (UTC)",
                    CompanyID =  57,
                    GenericName = "Abilify"
                },
                new Drug() {
                    id =  97,
                    CreateDate = "Fri Jun 13 1997 09:03:16 GMT+0000 (UTC)",
                    CompanyID =  52,
                    GenericName = "Clonazepam"
                },
                new Drug() {
                    id =  98,
                    CreateDate = "Wed Jan 04 1984 07:12:56 GMT+0000 (UTC)",
                    CompanyID =  27,
                    GenericName = "Digoxin"
                },
                new Drug() {
                    id =  99,
                    CreateDate = "Wed Sep 21 1983 01:13:44 GMT+0000 (UTC)",
                    CompanyID =  30,
                    GenericName = "Diovan"
                },
                new Drug() {
                    id =  100,
                    CreateDate = "Sun Jun 21 1992 02:51:19 GMT+0000 (UTC)",
                    CompanyID =  14,
                    GenericName = "Carvedilol"
                },
                new Drug() {
                    id =  101,
                    CreateDate = "Sat Feb 22 1986 14:00:23 GMT+0000 (UTC)",
                    CompanyID =  33,
                    GenericName = "Gianvi"
                },
                new Drug() {
                    id =  102,
                    CreateDate = "Tue Sep 08 1998 17:52:56 GMT+0000 (UTC)",
                    CompanyID =  61,
                    GenericName = "Ibuprofen (Rx)"
                },
                new Drug() {
                    id =  103,
                    CreateDate = "Sat Apr 05 1980 02:26:54 GMT+0000 (UTC)",
                    CompanyID =  42,
                    GenericName = "LevothyroxineSodium"
                },
                new Drug() {
                    id =  104,
                    CreateDate = "Thu Aug 26 1999 05:58:44 GMT+0000 (UTC)",
                    CompanyID =  10,
                    GenericName = "Plavix"
                },
                new Drug() {
                    id =  105,
                    CreateDate = "Wed Mar 07 1990 20:04:24 GMT+0000 (UTC)",
                    CompanyID =  45,
                    GenericName = "Potassium Chloride"
                },
                new Drug() {
                    id =  106,
                    CreateDate = "Thu Mar 13 1986 03:32:52 GMT+0000 (UTC)",
                    CompanyID =  22,
                    GenericName = "Tramadol HCl"
                },
                new Drug() {
                    id =  107,
                    CreateDate = "Sun May 04 2008 22:27:53 GMT+0000 (UTC)",
                    CompanyID =  56,
                    GenericName = "Omeprazole (Rx)"
                },
                new Drug() {
                    id =  108,
                    CreateDate = "Mon Feb 05 2018 02:40:52 GMT+0000 (UTC)",
                    CompanyID =  49,
                    GenericName = "Zolpidem Tartrate"
                },
                new Drug() {
                    id =  109,
                    CreateDate = "Thu Apr 28 1983 09:19:37 GMT+0000 (UTC)",
                    CompanyID =  57,
                    GenericName = "Furosemide"
                },
                new Drug() {
                    id =  110,
                    CreateDate = "Mon Nov 20 1978 16:50:04 GMT+0000 (UTC)",
                    CompanyID =  55,
                    GenericName = "Hydrocodone/APAP"
                },
                new Drug() {
                    id =  111,
                    CreateDate = "Wed Apr 23 2003 17:56:04 GMT+0000 (UTC)",
                    CompanyID =  54,
                    GenericName = "Amitriptyline HCl"
                },
                new Drug() {
                    id =  112,
                    CreateDate = "Sat Apr 01 1995 00:36:33 GMT+0000 (UTC)",
                    CompanyID =  35,
                    GenericName = "Citalopram HBR"
                },
                new Drug() {
                    id =  113,
                    CreateDate = "Tue Aug 13 2002 09:15:14 GMT+0000 (UTC)",
                    CompanyID =  15,
                    GenericName = "Azithromycin"
                },
                new Drug() {
                    id =  114,
                    CreateDate = "Sun Mar 16 1986 19:41:14 GMT+0000 (UTC)",
                    CompanyID =  16,
                    GenericName = "Gabapentin"
                },
                new Drug() {
                    id =  115,
                    CreateDate = "Fri Jun 17 1983 14:38:59 GMT+0000 (UTC)",
                    CompanyID =  40,
                    GenericName = "Lorazepam"
                },
                new Drug() {
                    id =  116,
                    CreateDate = "Sat Nov 02 1985 09:01:08 GMT+0000 (UTC)",
                    CompanyID =  28,
                    GenericName = "Prednisone"
                },
                new Drug() {
                    id =  117,
                    CreateDate = "Tue Aug 25 1992 05:15:01 GMT+0000 (UTC)",
                    CompanyID =  63,
                    GenericName = "Fluticasone Propionate"
                },
                new Drug() {
                    id =  118,
                    CreateDate = "Sat Jul 12 1980 09:37:42 GMT+0000 (UTC)",
                    CompanyID =  13,
                    GenericName = "Amlodipine Besylate"
                },
                new Drug() {
                    id =  119,
                    CreateDate = "Tue Sep 26 1978 03:42:39 GMT+0000 (UTC)",
                    CompanyID =  5,
                    GenericName = "Amoxicillin"
                },
                new Drug() {
                    id =  120,
                    CreateDate = "Wed Jun 06 1984 13:09:55 GMT+0000 (UTC)",
                    CompanyID =  2,
                    GenericName = "Promethazine HCl"
                },
                new Drug() {
                    id =  121,
                    CreateDate = "Tue Nov 28 1995 00:18:17 GMT+0000 (UTC)",
                    CompanyID =  1,
                    GenericName = "Sertraline HCl"
                },
                new Drug() {
                    id =  122,
                    CreateDate = "Mon Jun 05 2017 01:39:13 GMT+0000 (UTC)",
                    CompanyID =  54,
                    GenericName = "Metformin HCl"
                },
                new Drug() {
                    id =  123,
                    CreateDate = "Sat Jun 18 2005 13:30:37 GMT+0000 (UTC)",
                    CompanyID =  5,
                    GenericName = "Alprazolam"
                },
                new Drug() {
                    id =  124,
                    CreateDate = "Mon May 25 2015 01:50:14 GMT+0000 (UTC)",
                    CompanyID =  7,
                    GenericName = "Simvastatin"
                },
                new Drug() {
                    id =  125,
                    CreateDate = "Sat May 03 2008 02:50:49 GMT+0000 (UTC)",
                    CompanyID =  8,
                    GenericName = "Lisinopril"
                }
            };
        }

        public Task<Drug> GetDrugByIdAsync(int id)
        {
            return Task.FromResult(_drugs.Single(xx => Equals(xx.id, id)));
        }

        public Task<IEnumerable<Drug>> GetDrugsAsync()
        {
            return Task.FromResult(_drugs.AsEnumerable());
        }
    }

    public interface IDrugService
    {
        Task<Drug> GetDrugByIdAsync(int id);
        Task<IEnumerable<Drug>> GetDrugsAsync();

    }
}
