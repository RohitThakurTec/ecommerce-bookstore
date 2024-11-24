using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommProject_1155.Utility
{
    public  static class SD  
    { //category type SD//
        public const string Proc_GetCategorys = "GetCategory";
        public const string Proc_GetCategory = "SP_GetCategory";
        public const string Proc_CreateCategory = "SP_CreateCategory";
        public const string Proc_UpdateCategory = "SP_UpdateCategory";
        public const string Proc_DeleteCategory = "SP_DeleteCategory";

        //roles//
        public const string Role_Admin = "Admin";
        public const string Role_EmployeeUser = "EmployeeUser";
        public const string Role_CompanyUser = "CompanyUser";
        public const string Role_IndividualUser = "IndividualUser";

        //session//
        public const string Ss_CartSessionCount = "CartSessionCount";
        //
        public static double GetPriceBasedOnQuentity(double quentity, double price, double Price50, double price100)
        {
            if (quentity < 50)
                return price;
            else if (quentity < 100)
                return Price50;
            else
                return price100;

        }
        //order status//
        public const string OrderStatusPending = "Pending";
        public const string OrderStatusPendingApproved = "Approved";
        public const string OrderStatusInShipped = "Shipped";
        public const string OrderStatusCencelled = "Cenclled";
        public const string OrderStatusRefunded= "Refunded";
        //Order Pending//
        public const string PaymentStatusPending = "Pending";
        public const string PaymentStatusApproved = "Approved";
        public const string PaymentStatusDelayPayment = "PaymentStatsDelay";
        public const string PaymentStatusRejected = "Rejected";

    }
}
