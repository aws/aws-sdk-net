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
    /// Container for the parameters to the DescribeUser operation. Returns information about
    /// a specific user.
    /// </summary>
    public partial class DescribeUserRequest : AmazonDirectoryServiceDataRequest
    {
        /// <summary>
        /// Gets and sets the property DirectoryId. 
        /// <para>
        ///  The identifier (ID) of the directory that's associated with the user. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DirectoryId { get; set; }

        /// <summary>
        /// Checks to see if the DirectoryId property is set.
        /// </summary>
        internal bool IsSetDirectoryId() => this.DirectoryId != null;

        /// <summary>
        /// Gets and sets the property OtherAttributes. 
        /// <para>
        ///  One or more attribute names to be returned for the user. A key is an attribute name,
        /// and the value is a list of maps. For a list of supported attributes, see <a href="https://docs.aws.amazon.com/directoryservice/latest/admin-guide/ad_data_attributes.html">Directory
        /// Service Data Attributes</a>. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 25)]
        public List<string> OtherAttributes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the OtherAttributes property is set.
        /// </summary>
        internal bool IsSetOtherAttributes() => this.OtherAttributes != null && (this.OtherAttributes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Realm. 
        /// <para>
        ///  The domain name that's associated with the user. 
        /// </para>
        ///  <note> 
        /// <para>
        ///  This parameter is optional, so you can return users outside your Managed Microsoft
        /// AD domain. When no value is defined, only your Managed Microsoft AD users are returned.
        /// 
        /// </para>
        ///  
        /// <para>
        ///  This value is case insensitive. 
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string Realm { get; set; }

        /// <summary>
        /// Checks to see if the Realm property is set.
        /// </summary>
        internal bool IsSetRealm() => this.Realm != null;

        /// <summary>
        /// Gets and sets the property SAMAccountName. 
        /// <para>
        ///  The name of the user. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 20)]
        public string SAMAccountName { get; set; }

        /// <summary>
        /// Checks to see if the SAMAccountName property is set.
        /// </summary>
        internal bool IsSetSAMAccountName() => this.SAMAccountName != null;
    }
}
