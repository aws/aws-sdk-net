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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.OpsWorks.Model
{
    /// <summary>
    /// Container for the parameters to the SetPermission operation.
    /// <para>Specifies a stack's permissions. For more information, see <a
    /// href="http://docs.aws.amazon.com/opsworks/latest/userguide/workingsecurity.html" >Security and Permissions</a> .</para>
    /// </summary>
    /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.SetPermission"/>
    public class SetPermissionRequest : AmazonWebServiceRequest
    {
        private string stackId;
        private string iamUserArn;
        private bool? allowSsh;
        private bool? allowSudo;

        /// <summary>
        /// The stack ID.
        ///  
        /// </summary>
        public string StackId
        {
            get { return this.stackId; }
            set { this.stackId = value; }
        }

        /// <summary>
        /// Sets the StackId property
        /// </summary>
        /// <param name="stackId">The value to set for the StackId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public SetPermissionRequest WithStackId(string stackId)
        {
            this.stackId = stackId;
            return this;
        }
            

        // Check to see if StackId property is set
        internal bool IsSetStackId()
        {
            return this.stackId != null;
        }

        /// <summary>
        /// The user's IAM ARN.
        ///  
        /// </summary>
        public string IamUserArn
        {
            get { return this.iamUserArn; }
            set { this.iamUserArn = value; }
        }

        /// <summary>
        /// Sets the IamUserArn property
        /// </summary>
        /// <param name="iamUserArn">The value to set for the IamUserArn property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public SetPermissionRequest WithIamUserArn(string iamUserArn)
        {
            this.iamUserArn = iamUserArn;
            return this;
        }
            

        // Check to see if IamUserArn property is set
        internal bool IsSetIamUserArn()
        {
            return this.iamUserArn != null;
        }

        /// <summary>
        /// The user is allowed to use SSH to communicate with the instance.
        ///  
        /// </summary>
        public bool AllowSsh
        {
            get { return this.allowSsh ?? default(bool); }
            set { this.allowSsh = value; }
        }

        /// <summary>
        /// Sets the AllowSsh property
        /// </summary>
        /// <param name="allowSsh">The value to set for the AllowSsh property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public SetPermissionRequest WithAllowSsh(bool allowSsh)
        {
            this.allowSsh = allowSsh;
            return this;
        }
            

        // Check to see if AllowSsh property is set
        internal bool IsSetAllowSsh()
        {
            return this.allowSsh.HasValue;
        }

        /// <summary>
        /// The user is allowed to use <b>sudo</b> to elevate privileges.
        ///  
        /// </summary>
        public bool AllowSudo
        {
            get { return this.allowSudo ?? default(bool); }
            set { this.allowSudo = value; }
        }

        /// <summary>
        /// Sets the AllowSudo property
        /// </summary>
        /// <param name="allowSudo">The value to set for the AllowSudo property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public SetPermissionRequest WithAllowSudo(bool allowSudo)
        {
            this.allowSudo = allowSudo;
            return this;
        }
            

        // Check to see if AllowSudo property is set
        internal bool IsSetAllowSudo()
        {
            return this.allowSudo.HasValue;
        }
    }
}
    
