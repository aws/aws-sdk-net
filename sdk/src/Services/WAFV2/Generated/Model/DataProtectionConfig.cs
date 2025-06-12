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
 * Do not modify this file. This file is generated from the wafv2-2019-07-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.WAFV2.Model
{
    /// <summary>
    /// Specifies data protection to apply to the web request data for the web ACL. This is
    /// a web ACL level data protection option. 
    /// 
    ///  
    /// <para>
    /// The data protection that you configure for the web ACL alters the data that's available
    /// for any other data collection activity, including your WAF logging destinations, web
    /// ACL request sampling, and Amazon Security Lake data collection and management. Your
    /// other option for data protection is in the logging configuration, which only affects
    /// logging. 
    /// </para>
    ///  
    /// <para>
    /// This is part of the data protection configuration for a web ACL. 
    /// </para>
    /// </summary>
    public partial class DataProtectionConfig
    {
        private List<DataProtection> _dataProtections = AWSConfigs.InitializeCollections ? new List<DataProtection>() : null;

        /// <summary>
        /// Gets and sets the property DataProtections. 
        /// <para>
        /// An array of data protection configurations for specific web request field types. This
        /// is defined for each web ACL. WAF applies the specified protection to all web requests
        /// that the web ACL inspects. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=26)]
        public List<DataProtection> DataProtections
        {
            get { return this._dataProtections; }
            set { this._dataProtections = value; }
        }

        // Check to see if DataProtections property is set
        internal bool IsSetDataProtections()
        {
            return this._dataProtections != null && (this._dataProtections.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}