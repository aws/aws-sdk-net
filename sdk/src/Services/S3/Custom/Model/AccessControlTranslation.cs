/*
 * Copyright 2010-2017 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.Linq;
using System.Text;

namespace Amazon.S3.Model
{
    /// <summary>
    /// AccessControlTranslation class
    /// </summary>
    public class AccessControlTranslation
    {
        private OwnerOverride owner;

        /// <summary>
        /// The override value for the owner of the replica object.
        /// </summary>
        public OwnerOverride Owner
        {
            get { return this.owner; }
            set { this.owner = value; }
        }
        // Check to see if Owner property is set
        internal bool IsSetOwner()
        {
            return this.owner != null;
        }
    }
}