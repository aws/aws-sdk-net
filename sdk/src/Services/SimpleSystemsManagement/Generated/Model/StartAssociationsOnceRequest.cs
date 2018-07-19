/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Container for the parameters to the StartAssociationsOnce operation.
    /// Use this API action to execute an association immediately and only one time. This
    /// action can be helpful when troubleshooting associations.
    /// </summary>
    public partial class StartAssociationsOnceRequest : AmazonSimpleSystemsManagementRequest
    {
        private List<string> _associationIds = new List<string>();

        /// <summary>
        /// Gets and sets the property AssociationIds. 
        /// <para>
        /// The association IDs that you want to execute immediately and only one time.
        /// </para>
        /// </summary>
        public List<string> AssociationIds
        {
            get { return this._associationIds; }
            set { this._associationIds = value; }
        }

        // Check to see if AssociationIds property is set
        internal bool IsSetAssociationIds()
        {
            return this._associationIds != null && this._associationIds.Count > 0; 
        }

    }
}