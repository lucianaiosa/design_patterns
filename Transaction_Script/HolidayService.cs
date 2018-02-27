using System;

namespace Transaction_Script
{
	public static class HolidayService
	{
		public static bool BookHolidayFor(int employeeId,DateTime from,DateTime to)
		{
			bool booked = false;
			TimeSpan numberOfDaysRequestedForHolidays = to - from;

			if(numberOfDaysRequestedForHolidays.Days>0)
			{
				int holidaysAvailabile = GetHolidaysRemainingFor(employeeId);

				if(holidaysAvailabile >= numberOfDaysRequestedForHolidays.Days)
				{
					SubmitHolidayBookingFor(employeeId, from, to);
				}

			}
			return booked;
		}

		private static void SubmitHolidayBookingFor(int employeeId, object from, object to)
		{
			
		}

		private static int GetHolidaysRemainingFor(int employeeId)
		{
			return 1;
		}


	}
}

