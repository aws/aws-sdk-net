/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the location-2020-11-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.LocationService.Model
{
    /// <summary>
    /// This is the response object from the CreateMap operation.
    /// </summary>
    public partial class CreateMapResponse : AmazonWebServiceResponse
    {
        private DateTime? _createTime;
        private string _mapArn;
        private string _mapName;

        /// <summary>
        /// Gets and sets the property CreateTime. 
        /// <para>
        /// The timestamp for when the map resource was created in <a href="https://www.iso.org/iso-8601-date-and-time-format.html">ISO
        /// 8601</a> format: <code>YYYY-MM-DDThh:mm:ss.sssZ</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime CreateTime
        {
            get { return this._createTime.GetValueOrDefault(); }
            set { this._createTime = value; }
        }

        // Check to see if CreateTime property is set
        internal bool IsSetCreateTime()
        {
            return this._createTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MapArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the map resource. Used to specify a resource across
        /// all Amazon Web Services.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Format example: <code>arn:aws:geo:region:account-id:map/ExampleMap</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1600)]
        public string MapArn
        {
            get { return this._mapArn; }
            set { this._mapArn = value; }
        }

        // Check to see if MapArn property is set
        internal bool IsSetMapArn()
        {
            return this._mapArn != null;
        }

        /// <summary>
        /// Gets and sets the property MapName. 
        /// <para>
        /// The name of the map resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string MapName
        {
            get { return this._mapName; }
            set { this._mapName = value; }
        }

        // Check to see if MapName property is set
        internal bool IsSetMapName()
        {
            return this._mapName != null;
        }

    }
}