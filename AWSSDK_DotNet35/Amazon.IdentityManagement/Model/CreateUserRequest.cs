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

namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// Container for the parameters to the CreateUser operation.
    /// <para>Creates a new user for your AWS account.</para> <para>For information about limitations on the number of users you can create, see <a
    /// href="http://docs.aws.amazon.com/IAM/latest/UserGuide/index.html?LimitationsOnEntities.html" >Limitations on IAM Entities</a> in <i>Using
    /// AWS Identity and Access Management</i> .</para>
    /// </summary>
    public partial class CreateUserRequest : AmazonIdentityManagementServiceRequest
    {
        private string path;
        private string userName;


        /// <summary>
        /// The path for the user name. For more information about paths, see <a
        /// href="http://docs.aws.amazon.com/IAM/latest/UserGuide/index.html?Using_Identifiers.html" target="_blank">Identifiers for IAM Entities</a> in
        /// <i>Using AWS Identity and Access Management</i>. This parameter is optional. If it is not included, it defaults to a slash (/).
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 512</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>(\u002F)|(\u002F[\u0021-\u007F]+\u002F)</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Path
        {
            get { return this.path; }
            set { this.path = value; }
        }

        // Check to see if Path property is set
        internal bool IsSetPath()
        {
            return this.path != null;
        }

        /// <summary>
        /// Name of the user to create.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 64</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\w+=,.@-]*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string UserName
        {
            get { return this.userName; }
            set { this.userName = value; }
        }

        // Check to see if UserName property is set
        internal bool IsSetUserName()
        {
            return this.userName != null;
        }

    }
}
    
