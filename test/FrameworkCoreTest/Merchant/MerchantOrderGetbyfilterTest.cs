﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WX.Model.ApiRequests;
using WX.Model.ApiResponses;
using Xunit;

namespace FrameworkCoreTest.Merchant
{
    public class MerchantOrderGetbyfilterTest : MockPostApiBaseTest<MerchantOrderGetbyfilterRequest, MerchantOrderGetbyfilterResponse>
    {
        [Fact]
        public void MockSuccess()
        {
            MockSetup(false);
            var response = mock_client.Object.Execute(Request);
            Assert.Equal(2, response.OrderList.Count());
        }

        protected override MerchantOrderGetbyfilterRequest InitRequestObject()
        {
            return new MerchantOrderGetbyfilterRequest
            {
                AccessToken = "123",
                Status = WX.Model.OrderStatus.All,
                BeginTime = new DateTime(2014,1,1),
                EndTime = new DateTime(2014,4,1)
            };

        }

        protected override string GetReturnResult(bool errResult)
        {
            if (errResult) return s_errmsg;
            return JsonSerialize(new
            {
                errcode = 0,
                errmsg = "success",
                order_list = new[]
                {
                    new {
                        order_id = "7197417460812533543",
                        order_status = 6,
                        order_total_price = 6,
                        order_create_time = 1394635817,
                        order_express_price = 5,
                        buyer_openid = "0DF3iY17NsDAW4UP2qzJXPsz1S9Q",
                        buyer_nick = "likeacat",
                        receiver_name = "zhang xiao mao",
                        receiver_province = "guangdongsheng",
                        receiver_city = "guangzhoushi",
                        receiver_address = "huajingluyihao",
                        receiver_mobile = "123456789",
                        receiver_phone = "123456789",
                        product_id = "pDF3iYx7KDQVGzB8kDg6Tge50kFo",
                        product_name = "anlifang e-bar jlajsdkfj",
                        product_price = 1,
                        product_sku = "10000983:10000995;10001007:10001010",
                        product_count = 1,
                        product_img = "http://img2.paipaiimg.com/0000000/item-5232.jpg",
                        delivery_id = "19006597372473",
                        delivery_company = "059Yunda",
                        trans_id = "1900000109201404103172199813"
                    },
                    new {
                        order_id = "7197417460812533545",
                        order_status = 6,
                        order_total_price = 6,
                        order_create_time = 1394635817,
                        order_express_price = 5,
                        buyer_openid = "0DF3iY17NsDAW4UP2qzJXPsz1S9Q",
                        buyer_nick = "likeacat",
                        receiver_name = "zhang xiao mao",
                        receiver_province = "guangdongsheng",
                        receiver_city = "guangzhoushi",
                        receiver_address = "huajingluyihao",
                        receiver_mobile = "123456789",
                        receiver_phone = "123456789",
                        product_id = "pDF3iYx7KDQVGzB8kDg6Tge50kFo",
                        product_name = "anlifang e-bar jlajsdkfj",
                        product_price = 1,
                        product_sku = "10000983:10000995;10001007:10001010",
                        product_count = 1,
                        product_img = "http://img2.paipaiimg.com/0000000/item-5232.jpg",
                        delivery_id = "19006597372473",
                        delivery_company = "059Yunda",
                        trans_id = "1900000109201404103172199813"
                    },
                }
            });
        }
    }
}
