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

namespace Amazon.WellArchitected.Model
{
    /// <summary>
    /// A lens summary of a lens.
    /// </summary>
    public partial class LensSummary
    {
        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time when the lens was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Description.
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property LensAlias.
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string LensAlias { get; set; }

        /// <summary>
        /// Checks to see if the LensAlias property is set.
        /// </summary>
        internal bool IsSetLensAlias() => this.LensAlias != null;

        /// <summary>
        /// Gets and sets the property LensArn. 
        /// <para>
        /// The ARN of the lens.
        /// </para>
        /// </summary>
        public string LensArn { get; set; }

        /// <summary>
        /// Checks to see if the LensArn property is set.
        /// </summary>
        internal bool IsSetLensArn() => this.LensArn != null;

        /// <summary>
        /// Gets and sets the property LensName.
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string LensName { get; set; }

        /// <summary>
        /// Checks to see if the LensName property is set.
        /// </summary>
        internal bool IsSetLensName() => this.LensName != null;

        /// <summary>
        /// Gets and sets the property LensStatus. 
        /// <para>
        /// The status of the lens.
        /// </para>
        /// </summary>
        public LensStatus LensStatus { get; set; }

        /// <summary>
        /// Checks to see if the LensStatus property is set.
        /// </summary>
        internal bool IsSetLensStatus() => this.LensStatus != null;

        /// <summary>
        /// Gets and sets the property LensType. 
        /// <para>
        /// The type of the lens.
        /// </para>
        /// </summary>
        public LensType LensType { get; set; }

        /// <summary>
        /// Checks to see if the LensType property is set.
        /// </summary>
        internal bool IsSetLensType() => this.LensType != null;

        /// <summary>
        /// Gets and sets the property LensVersion. 
        /// <para>
        /// The version of the lens.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 32)]
        public string LensVersion { get; set; }

        /// <summary>
        /// Checks to see if the LensVersion property is set.
        /// </summary>
        internal bool IsSetLensVersion() => this.LensVersion != null;

        /// <summary>
        /// Gets and sets the property Owner.
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string Owner { get; set; }

        /// <summary>
        /// Checks to see if the Owner property is set.
        /// </summary>
        internal bool IsSetOwner() => this.Owner != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The date and time when the lens was last updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
