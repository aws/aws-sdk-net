/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.SecurityToken.Model
{
    /// <summary>
    /// <para>Identifiers for the federated user that is associated with the credentials.</para>
    /// </summary>
    public class FederatedUser
    {
        
        private string federatedUserId;
        private string arn;

        /// <summary>
        /// The string that identifies the federated user associated with the credentials, similar to the unique ID of an IAM user.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>2 - 96</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\w+=,.@\:-]*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string FederatedUserId
        {
            get { return this.federatedUserId; }
            set { this.federatedUserId = value; }
        }

        /// <summary>
        /// Sets the FederatedUserId property
        /// </summary>
        /// <param name="federatedUserId">The value to set for the FederatedUserId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public FederatedUser WithFederatedUserId(string federatedUserId)
        {
            this.federatedUserId = federatedUserId;
            return this;
        }
            

        // Check to see if FederatedUserId property is set
        internal bool IsSetFederatedUserId()
        {
            return this.federatedUserId != null;
        }

        /// <summary>
        /// The ARN that specifies the federated user that is associated with the credentials. For more information about ARNs and how to use them in
        /// policies, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/Using_Identifiers.html" target="_blank">Identifiers for IAM
        /// Entities</a> in <i>Using IAM</i>.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>20 - 2048</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Arn
        {
            get { return this.arn; }
            set { this.arn = value; }
        }

        /// <summary>
        /// Sets the Arn property
        /// </summary>
        /// <param name="arn">The value to set for the Arn property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public FederatedUser WithArn(string arn)
        {
            this.arn = arn;
            return this;
        }
            

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this.arn != null;
        }
    }
}
