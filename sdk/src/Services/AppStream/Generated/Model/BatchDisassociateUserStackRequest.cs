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
 * Do not modify this file. This file is generated from the appstream-2016-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AppStream.Model
{
    /// <summary>
    /// Container for the parameters to the BatchDisassociateUserStack operation.
    /// Disassociates the specified users from the specified stacks.
    /// </summary>
    public partial class BatchDisassociateUserStackRequest : AmazonAppStreamRequest
    {
        private List<UserStackAssociation> _userStackAssociations = new List<UserStackAssociation>();

        /// <summary>
        /// Gets and sets the property UserStackAssociations. 
        /// <para>
        /// The list of UserStackAssociation objects.
        /// </para>
        /// </summary>
        public List<UserStackAssociation> UserStackAssociations
        {
            get { return this._userStackAssociations; }
            set { this._userStackAssociations = value; }
        }

        // Check to see if UserStackAssociations property is set
        internal bool IsSetUserStackAssociations()
        {
            return this._userStackAssociations != null && this._userStackAssociations.Count > 0; 
        }

    }
}