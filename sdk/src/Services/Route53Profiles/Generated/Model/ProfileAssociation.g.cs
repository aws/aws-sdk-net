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

namespace Amazon.Route53Profiles.Model
{
    /// <summary>
    /// An association between a Route 53 Profile and a VPC.
    /// </summary>
    public partial class ProfileAssociation
    {
        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        ///  The date and time that the Profile association was created, in Unix time format and
        /// Coordinated Universal Time (UTC). 
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        ///  ID of the Profile association. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property ModificationTime. 
        /// <para>
        ///  The date and time that the Profile association was modified, in Unix time format
        /// and Coordinated Universal Time (UTC). 
        /// </para>
        /// </summary>
        public DateTime? ModificationTime { get; set; }

        /// <summary>
        /// Checks to see if the ModificationTime property is set.
        /// </summary>
        internal bool IsSetModificationTime() => this.ModificationTime.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        ///  Name of the Profile association. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 64)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property OwnerId. 
        /// <para>
        ///  Amazon Web Services account ID of the Profile association owner. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 32)]
        public string OwnerId { get; set; }

        /// <summary>
        /// Checks to see if the OwnerId property is set.
        /// </summary>
        internal bool IsSetOwnerId() => this.OwnerId != null;

        /// <summary>
        /// Gets and sets the property ProfileId. 
        /// <para>
        ///  ID of the Profile. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ProfileId { get; set; }

        /// <summary>
        /// Checks to see if the ProfileId property is set.
        /// </summary>
        internal bool IsSetProfileId() => this.ProfileId != null;

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the VPC. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ResourceId { get; set; }

        /// <summary>
        /// Checks to see if the ResourceId property is set.
        /// </summary>
        internal bool IsSetResourceId() => this.ResourceId != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        ///  Status of the Profile association. 
        /// </para>
        /// </summary>
        public ProfileStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        ///  Additional information about the Profile association. 
        /// </para>
        /// </summary>
        public string StatusMessage { get; set; }

        /// <summary>
        /// Checks to see if the StatusMessage property is set.
        /// </summary>
        internal bool IsSetStatusMessage() => this.StatusMessage != null;
    }
}
