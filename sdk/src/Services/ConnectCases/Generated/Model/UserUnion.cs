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
 * Do not modify this file. This file is generated from the connectcases-2022-10-03.normal.json service model.
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
namespace Amazon.ConnectCases.Model
{
    /// <summary>
    /// Represents the entity that performed the action.
    /// </summary>
    public partial class UserUnion
    {
        private string _customEntity;
        private string _userArn;

        /// <summary>
        /// Gets and sets the property CustomEntity. 
        /// <para>
        /// Any provided entity.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=500)]
        public string CustomEntity
        {
            get { return this._customEntity; }
            set { this._customEntity = value; }
        }

        // Check to see if CustomEntity property is set
        internal bool IsSetCustomEntity()
        {
            return this._customEntity != null;
        }

        /// <summary>
        /// Gets and sets the property UserArn. 
        /// <para>
        /// Represents the Amazon Connect ARN of the user.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=500)]
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

    }
}