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
 * Do not modify this file. This file is generated from the securitylake-2018-05-10.normal.json service model.
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
namespace Amazon.SecurityLake.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteDataLake operation.
    /// When you disable Amazon Security Lake from your account, Security Lake is disabled
    /// in all Amazon Web Services Regions and it stops collecting data from your sources.
    /// Also, this API automatically takes steps to remove the account from Security Lake.
    /// However, Security Lake retains all of your existing settings and the resources that
    /// it created in your Amazon Web Services account in the current Amazon Web Services
    /// Region.
    /// 
    ///  
    /// <para>
    /// The <c>DeleteDataLake</c> operation does not delete the data that is stored in your
    /// Amazon S3 bucket, which is owned by your Amazon Web Services account. For more information,
    /// see the <a href="https://docs.aws.amazon.com/security-lake/latest/userguide/disable-security-lake.html">Amazon
    /// Security Lake User Guide</a>.
    /// </para>
    /// </summary>
    public partial class DeleteDataLakeRequest : AmazonSecurityLakeRequest
    {
        private List<string> _regions = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Regions. 
        /// <para>
        /// The list of Regions where Security Lake is enabled.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> Regions
        {
            get { return this._regions; }
            set { this._regions = value; }
        }

        // Check to see if Regions property is set
        internal bool IsSetRegions()
        {
            return this._regions != null && (this._regions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}