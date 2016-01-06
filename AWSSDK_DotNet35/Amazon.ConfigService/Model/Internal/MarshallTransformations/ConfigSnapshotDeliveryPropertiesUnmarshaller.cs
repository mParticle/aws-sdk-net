/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.ConfigService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ConfigService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ConfigSnapshotDeliveryProperties Object
    /// </summary>  
    public class ConfigSnapshotDeliveryPropertiesUnmarshaller : IUnmarshaller<ConfigSnapshotDeliveryProperties, XmlUnmarshallerContext>, IUnmarshaller<ConfigSnapshotDeliveryProperties, JsonUnmarshallerContext>
    {
        ConfigSnapshotDeliveryProperties IUnmarshaller<ConfigSnapshotDeliveryProperties, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        public ConfigSnapshotDeliveryProperties Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            ConfigSnapshotDeliveryProperties unmarshalledObject = new ConfigSnapshotDeliveryProperties();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("deliveryFrequency", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DeliveryFrequency = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static ConfigSnapshotDeliveryPropertiesUnmarshaller _instance = new ConfigSnapshotDeliveryPropertiesUnmarshaller();        

        public static ConfigSnapshotDeliveryPropertiesUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}