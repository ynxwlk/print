using System;

namespace Print
{
	/// <summary>
	/// AMT_GB2312 ��ժҪ˵����
	/// </summary>
	public class AMT_GB2312
	{
		public AMT_GB2312()
		{
			//
			// TODO: �ڴ˴���ӹ��캯���߼�
			//
		}
		public string ConvertToGB2312(double amount)
		{
			string m_str,m_int,m_dec;
			int m_pos,m_len;

			m_str = System.Convert.ToString(amount);
			m_len = m_str.Length;
			m_pos = m_str.IndexOf('.',0);
			m_dec = "00";
			if (m_pos ==-1)
				m_int = m_str;
			else
			{
				m_int = m_str.Substring(0,m_pos);
				m_dec = m_str.Substring(m_pos+1 ,m_len -m_pos-1);
				m_dec = m_dec.PadRight(2,'0');
				m_dec = m_dec.Substring(0,2);
			}

			m_int = m_int.PadLeft(12,'0');

			m_str = "";
			if (m_int.Substring(0,4) != "0000")
			{
				m_str += ConvertTo9999(m_int.Substring(0,4)) + "��";
			}

			if (m_int.Substring(4,4) != "0000")
			{
				m_str += ConvertTo9999(m_int.Substring(4,4)) + "��";
			}
			if (m_int.Substring(8,4) != "0000")
			{
				m_str += ConvertTo9999(m_int.Substring(8,4)) + "Բ";
			}

			if (m_dec !="00")
			{
				m_str += ConvertDec(m_dec);
			}
			else
			{
				m_str += "��";
			}

			return m_str;

		}
		private string ConvertTo9999(string m_part)
		{
			string m_str;
			int m_val,m_tmp;
			
			m_str = "";
			m_val = (int)System.Convert.ToInt32(m_part,10);
			m_tmp = (int)m_val/1000;
			switch(m_tmp)
			{
				case 1:
					m_str = "ҼǪ";
					break;
				case 2:
					m_str = "��Ǫ";
					break;
				case 3:
					m_str = "��Ǫ";
					break;
				case 4:
					m_str = "��Ǫ";
					break;
				case 5:
					m_str = "��Ǫ";
					break;
				case 6:
					m_str = "½Ǫ";
					break;
				case 7:
					m_str = "��Ǫ";
					break;
				case 8:
					m_str = "��Ǫ";
					break;
				case 9:
					m_str = "��Ǫ";
					break;
				default:
					break;
			}

			m_val = m_val -(m_tmp*1000);
			m_tmp = (int)m_val/100;

			switch(m_tmp)
			{
				case 1:
					m_str += "Ҽ��";
					break;
				case 2:
					m_str += "����";
					break;
				case 3:
					m_str += "����";
					break;
				case 4:
					m_str += "����";
					break;
				case 5:
					m_str += "���";
					break;
				case 6:
					m_str += "½��";
					break;
				case 7:
					m_str += "���";
					break;
				case 8:
					m_str += "�ư�";
					break;
				case 9:
					m_str += "����";
					break;
				default:
					break;
			}
			m_val = m_val -(m_tmp*100);
			m_tmp = (int)m_val/10;

			switch(m_tmp)
			{
				case 1:
					m_str += "Ҽʰ";
					break;
				case 2:
					m_str += "��ʰ";
					break;
				case 3:
					m_str += "��ʰ";
					break;
				case 4:
					m_str += "��ʰ";
					break;
				case 5:
					m_str += "��ʰ";
					break;
				case 6:
					m_str += "½ʰ";
					break;
				case 7:
					m_str += "��ʰ";
					break;
				case 8:
					m_str += "��ʰ";
					break;
				case 9:
					m_str += "��ʰ";
					break;
				default:
					break;
			}

			m_val = m_val -(m_tmp*10);
			m_tmp = (int)m_val%10;

			switch(m_tmp)
			{
				case 1:
					m_str += "Ҽ";
					break;
				case 2:
					m_str += "��";
					break;
				case 3:
					m_str += "��";
					break;
				case 4:
					m_str += "��";
					break;
				case 5:
					m_str += "��";
					break;
				case 6:
					m_str += "½";
					break;
				case 7:
					m_str += "��";
					break;
				case 8:
					m_str += "��";
					break;
				case 9:
					m_str += "��";
					break;
				default:
					break;
			}

			return m_str;

		}
		private string ConvertDec(string m_part)
		{
			string m_str;
			int m_val;

			m_str = "";
			m_val = (int)System.Convert.ToInt32(m_part,10)/10;
			switch(m_val)
			{
				case  1:
					m_str = "Ҽ��";
					break;

				case  2:
					m_str = "����";
					break;
				case  3:
					m_str = "����";
					break;
				case  4:
					m_str = "����";
					break;
				case  5:
					m_str = "���";
					break;
				case  6:
					m_str = "½��";
					break;
				case  7:
					m_str = "���";
					break;

				case  8:
					m_str = "�ƽ�";
					break;
				case  9:
					m_str = "����";
					break;
				default:
					break;

			}

			m_val = (int)System.Convert.ToInt32(m_part,10)%10;

			switch(m_val)
			{
				case  1:
					m_str += "Ҽ��";
					break;

				case  2:
					m_str += "����";
					break;
				case  3:
					m_str += "����";
					break;
				case  4:
					m_str += "����";
					break;
				case  5:
					m_str += "���";
					break;
				case  6:
					m_str += "½��";
					break;
				case  7:
					m_str += "���";
					break;

				case  8:
					m_str += "�Ʒ�";
					break;
				case  9:
					m_str += "����";
					break;
				default:
					break;

			}


			return m_str;
		}
	}
}