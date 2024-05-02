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
 * Do not modify this file. This file is generated from the finspace-2021-03-12.normal.json service model.
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
namespace Amazon.Finspace.Model
{
    /// <summary>
    /// A structure that stores metadata for a kdb user.
    /// </summary>
    public partial class KxUser
    {
        private DateTime? _createTimestamp;
        private string _iamRole;
        private DateTime? _updateTimestamp;
        private string _userArn;
        private string _userName;

        /// <summary>
        /// Gets and sets the property CreateTimestamp. 
        /// <para>
        /// The timestamp at which the kdb user was created. 
        /// </para>
        /// </summary>
        public DateTime? CreateTimestamp
        {
            get { return this._createTimestamp; }
            set { this._createTimestamp = value; }
        }

        // Check to see if CreateTimestamp property is set
        internal bool IsSetCreateTimestamp()
        {
            return this._createTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IamRole. 
        /// <para>
        /// The IAM role ARN that is associated with the user.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string IamRole
        {
            get { return this._iamRole; }
            set { this._iamRole = value; }
        }

        // Check to see if IamRole property is set
        internal bool IsSetIamRole()
        {
            return this._iamRole != null;
        }

        /// <summary>
        /// Gets and sets the property UpdateTimestamp. 
        /// <para>
        /// The timestamp at which the kdb user was updated. 
        /// </para>
        /// </summary>
        public DateTime? UpdateTimestamp
        {
            get { return this._updateTimestamp; }
            set { this._updateTimestamp = value; }
        }

        // Check to see if UpdateTimestamp property is set
        internal bool IsSetUpdateTimestamp()
        {
            return this._updateTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UserArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) that identifies the user. For more information about
        /// ARNs and how to use ARNs in policies, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_identifiers.html">IAM
        /// Identifiers</a> in the <i>IAM User Guide</i>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string UserArn
        {
            get { return this._userArn; }
            set { this._userArn = value; }
        }

        // Check to see if UserArn property is set
        internal bool IsSetUserArn()
        {
            return this._userArn != null;
        }

        /// <summary>
        /// Gets and sets the property UserName. 
        /// <para>
        /// A unique identifier for the user.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public string UserName
        {
            get { return this._userName; }
            set { this._userName = value; }
        }

        // Check to see if UserName property is set
        internal bool IsSetUserName()
        {
            return this._userName != null;
        }

    }
}