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
 * Do not modify this file. This file is generated from the sns-2010-03-31.normal.json service model.
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
namespace Amazon.SimpleNotificationService.Model
{
    /// <summary>
    /// Container for the parameters to the PutDataProtectionPolicy operation.
    /// Adds or updates an inline policy document that is stored in the specified Amazon SNS
    /// topic.
    /// </summary>
    public partial class PutDataProtectionPolicyRequest : AmazonSimpleNotificationServiceRequest
    {
        private string _dataProtectionPolicy;
        private string _resourceArn;

        /// <summary>
        /// Gets and sets the property DataProtectionPolicy. 
        /// <para>
        /// The JSON serialization of the topic's <c>DataProtectionPolicy</c>.
        /// </para>
        ///  
        /// <para>
        /// The <c>DataProtectionPolicy</c> must be in JSON string format.
        /// </para>
        ///  
        /// <para>
        /// Length Constraints: Maximum length of 30,720.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DataProtectionPolicy
        {
            get { return this._dataProtectionPolicy; }
            set { this._dataProtectionPolicy = value; }
        }

        // Check to see if DataProtectionPolicy property is set
        internal bool IsSetDataProtectionPolicy()
        {
            return this._dataProtectionPolicy != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The ARN of the topic whose <c>DataProtectionPolicy</c> you want to add or update.
        /// </para>
        ///  
        /// <para>
        /// For more information about ARNs, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Names (ARNs)</a> in the Amazon Web Services General Reference.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ResourceArn
        {
            get { return this._resourceArn; }
            set { this._resourceArn = value; }
        }

        // Check to see if ResourceArn property is set
        internal bool IsSetResourceArn()
        {
            return this._resourceArn != null;
        }

    }
}