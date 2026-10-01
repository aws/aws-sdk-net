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

namespace Amazon.DataZone.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteFormType operation. Deletes and metadata
    /// form type in Amazon DataZone. <para> Prerequisites: </para> <ul> <li> <para> The form
    /// type must exist in the domain. </para> </li> <li> <para> The form type must not be
    /// in use by any asset types or assets. </para> </li> <li> <para> The domain must be
    /// valid and accessible. </para> </li> <li> <para> User must have delete permissions
    /// on the form type. </para> </li> <li> <para> Any dependencies (such as linked asset
    /// types) must be removed first. </para> </li> </ul>
    /// </summary>
    public partial class DeleteFormTypeRequest : AmazonDataZoneRequest
    {
        /// <summary>
        /// Gets and sets the property DomainIdentifier. 
        /// <para>
        /// The ID of the Amazon DataZone domain in which the metadata form type is deleted.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DomainIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the DomainIdentifier property is set.
        /// </summary>
        internal bool IsSetDomainIdentifier() => this.DomainIdentifier != null;

        /// <summary>
        /// Gets and sets the property FormTypeIdentifier. 
        /// <para>
        /// The ID of the metadata form type that is deleted.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 385)]
        public string FormTypeIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the FormTypeIdentifier property is set.
        /// </summary>
        internal bool IsSetFormTypeIdentifier() => this.FormTypeIdentifier != null;
    }
}
