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
 * Do not modify this file. This file is generated from the directory-service-data-2023-05-31.normal.json service model.
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
    /// Container for the parameters to the DescribeGroup operation.
    /// Returns information about a specific group.
    /// </summary>
    public partial class DescribeGroupRequest : AmazonDirectoryServiceDataRequest
    {
        private string _directoryId;
        private List<string> _otherAttributes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _realm;
        private string _samAccountName;

        /// <summary>
        /// Gets and sets the property DirectoryId. 
        /// <para>
        /// The Identifier (ID) of the directory associated with the group.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DirectoryId
        {
            get { return this._directoryId; }
            set { this._directoryId = value; }
        }

        // Check to see if DirectoryId property is set
        internal bool IsSetDirectoryId()
        {
            return this._directoryId != null;
        }

        /// <summary>
        /// Gets and sets the property OtherAttributes. 
        /// <para>
        ///  One or more attributes to be returned for the group. For a list of supported attributes,
        /// see <a href="https://docs.aws.amazon.com/directoryservice/latest/admin-guide/ad_data_attributes.html">Directory
        /// Service Data Attributes</a>. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=25)]
        public List<string> OtherAttributes
        {
            get { return this._otherAttributes; }
            set { this._otherAttributes = value; }
        }

        // Check to see if OtherAttributes property is set
        internal bool IsSetOtherAttributes()
        {
            return this._otherAttributes != null && (this._otherAttributes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Realm. 
        /// <para>
        ///  The domain name that's associated with the group. 
        /// </para>
        ///  <note> 
        /// <para>
        ///  This parameter is optional, so you can return groups outside of your Managed Microsoft
        /// AD domain. When no value is defined, only your Managed Microsoft AD groups are returned.
        /// 
        /// </para>
        ///  
        /// <para>
        ///  This value is case insensitive. 
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string Realm
        {
            get { return this._realm; }
            set { this._realm = value; }
        }

        // Check to see if Realm property is set
        internal bool IsSetRealm()
        {
            return this._realm != null;
        }

        /// <summary>
        /// Gets and sets the property SAMAccountName. 
        /// <para>
        ///  The name of the group. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string SAMAccountName
        {
            get { return this._samAccountName; }
            set { this._samAccountName = value; }
        }

        // Check to see if SAMAccountName property is set
        internal bool IsSetSAMAccountName()
        {
            return this._samAccountName != null;
        }

    }
}