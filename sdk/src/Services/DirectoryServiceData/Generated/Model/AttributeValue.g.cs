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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.DirectoryServiceData.Model
{
    /// <summary>
    /// The data type for an attribute. Each attribute value is described as a name-value
    /// pair. The name is the AD schema name, and the value is the data itself. For a list
    /// of supported attributes, see <a href="https://docs.aws.amazon.com/directoryservice/latest/admin-guide/ad_data_attributes.html">Directory
    /// Service Data Attributes</a>.
    /// </summary>
    public partial class AttributeValue
    {
        /// <summary>
        /// Gets and sets the property BOOL. 
        /// <para>
        ///  Indicates that the attribute type value is a boolean. For example: 
        /// </para>
        ///  
        /// <para>
        ///  <c>"BOOL": true</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public bool? BOOL { get; set; }

        /// <summary>
        /// Checks to see if the BOOL property is set.
        /// </summary>
        internal bool IsSetBOOL() => this.BOOL.HasValue;

        /// <summary>
        /// Gets and sets the property N. 
        /// <para>
        ///  Indicates that the attribute type value is a number. For example: 
        /// </para>
        ///  
        /// <para>
        ///  <c>"N": "16"</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public long? N { get; set; }

        /// <summary>
        /// Checks to see if the N property is set.
        /// </summary>
        internal bool IsSetN() => this.N.HasValue;

        /// <summary>
        /// Gets and sets the property S. 
        /// <para>
        ///  Indicates that the attribute type value is a string. For example: 
        /// </para>
        ///  
        /// <para>
        ///  <c>"S": "S Group"</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 1024)]
        public string S { get; set; }

        /// <summary>
        /// Checks to see if the S property is set.
        /// </summary>
        internal bool IsSetS() => this.S != null;

        /// <summary>
        /// Gets and sets the property SS. 
        /// <para>
        ///  Indicates that the attribute type value is a string set. For example: 
        /// </para>
        ///  
        /// <para>
        ///  <c>"SS": ["sample_service_class/host.sample.com:1234/sample_service_name_1", "sample_service_class/host.sample.com:1234/sample_service_name_2"]</c>
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 25)]
        public List<string> SS { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SS property is set.
        /// </summary>
        internal bool IsSetSS() => this.SS != null && (this.SS.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
