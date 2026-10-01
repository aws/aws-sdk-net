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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.TaxSettings.Model
{
    /// <summary>
    /// Tax inheritance information associated with the account.
    /// </summary>
    public partial class TaxInheritanceDetails
    {
        /// <summary>
        /// Gets and sets the property InheritanceObtainedReason. 
        /// <para>
        ///  Tax inheritance reason information associated with the account. 
        /// </para>
        /// </summary>
        public string InheritanceObtainedReason { get; set; }

        /// <summary>
        /// Checks to see if the InheritanceObtainedReason property is set.
        /// </summary>
        internal bool IsSetInheritanceObtainedReason() => this.InheritanceObtainedReason != null;

        /// <summary>
        /// Gets and sets the property ParentEntityId. 
        /// <para>
        ///  Tax inheritance parent account information associated with the account. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string ParentEntityId { get; set; }

        /// <summary>
        /// Checks to see if the ParentEntityId property is set.
        /// </summary>
        internal bool IsSetParentEntityId() => this.ParentEntityId != null;
    }
}
