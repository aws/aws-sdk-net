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

namespace Amazon.MarketplaceCatalog.Model
{
    /// <summary>
    /// An object that contains summary information about a subsidiary authorization, including
    /// its name, status, authorized resource, subsidiary account, and creation date. A subsidiary
    /// authorization lets a seller authorize one of its subsidiary accounts to create offers
    /// for one of its products.
    /// </summary>
    public partial class SubsidiaryAuthorizationSummary
    {
        /// <summary>
        /// Gets and sets the property CreatedDate. 
        /// <para>
        /// The date the subsidiary authorization was created.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 20)]
        public string CreatedDate { get; set; }

        /// <summary>
        /// Checks to see if the CreatedDate property is set.
        /// </summary>
        internal bool IsSetCreatedDate() => this.CreatedDate != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the subsidiary authorization.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// The ID of the resource that the subsidiary authorization applies to. Currently, this
        /// is always a product ID, such as <c>prod-example123</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string ResourceId { get; set; }

        /// <summary>
        /// Checks to see if the ResourceId property is set.
        /// </summary>
        internal bool IsSetResourceId() => this.ResourceId != null;

        /// <summary>
        /// Gets and sets the property ResourceName. 
        /// <para>
        /// The name of the resource that the subsidiary authorization applies to. Currently,
        /// this is always a product name.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string ResourceName { get; set; }

        /// <summary>
        /// Checks to see if the ResourceName property is set.
        /// </summary>
        internal bool IsSetResourceName() => this.ResourceName != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the subsidiary authorization. Valid values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Draft</c> - The subsidiary authorization was created but not yet released. The
        /// subsidiary account can't see it.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Active</c> - The subsidiary account can use the subsidiary authorization to create
        /// offers for the authorized product.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Restricted</c> - The subsidiary authorization was discarded while in <c>Draft</c>
        /// or revoked while <c>Active</c>. It can't be used to create new offers. This status
        /// is final.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property SubsidiaryAccountId. 
        /// <para>
        /// The 12-digit AWS account ID of the subsidiary account.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string SubsidiaryAccountId { get; set; }

        /// <summary>
        /// Checks to see if the SubsidiaryAccountId property is set.
        /// </summary>
        internal bool IsSetSubsidiaryAccountId() => this.SubsidiaryAccountId != null;
    }
}
