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
 * Do not modify this file. This file is generated from the cleanroomsml-2023-09-06.normal.json service model.
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
namespace Amazon.CleanRoomsML.Model
{
    /// <summary>
    /// Container for the parameters to the StartAudienceGenerationJob operation.
    /// Information necessary to start the audience generation job.
    /// </summary>
    public partial class StartAudienceGenerationJobRequest : AmazonCleanRoomsMLRequest
    {
        private string _collaborationId;
        private string _configuredAudienceModelArn;
        private string _description;
        private bool? _includeSeedInOutput;
        private string _name;
        private AudienceGenerationJobDataSource _seedAudience;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property CollaborationId. 
        /// <para>
        /// The identifier of the collaboration that contains the audience generation job.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string CollaborationId
        {
            get { return this._collaborationId; }
            set { this._collaborationId = value; }
        }

        // Check to see if CollaborationId property is set
        internal bool IsSetCollaborationId()
        {
            return this._collaborationId != null;
        }

        /// <summary>
        /// Gets and sets the property ConfiguredAudienceModelArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the configured audience model that is used for this
        /// audience generation job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string ConfiguredAudienceModelArn
        {
            get { return this._configuredAudienceModelArn; }
            set { this._configuredAudienceModelArn = value; }
        }

        // Check to see if ConfiguredAudienceModelArn property is set
        internal bool IsSetConfiguredAudienceModelArn()
        {
            return this._configuredAudienceModelArn != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the audience generation job.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=255)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property IncludeSeedInOutput. 
        /// <para>
        /// Whether the seed audience is included in the audience generation output.
        /// </para>
        /// </summary>
        public bool? IncludeSeedInOutput
        {
            get { return this._includeSeedInOutput; }
            set { this._includeSeedInOutput = value; }
        }

        // Check to see if IncludeSeedInOutput property is set
        internal bool IsSetIncludeSeedInOutput()
        {
            return this._includeSeedInOutput.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the audience generation job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property SeedAudience. 
        /// <para>
        /// The seed audience that is used to generate the audience.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AudienceGenerationJobDataSource SeedAudience
        {
            get { return this._seedAudience; }
            set { this._seedAudience = value; }
        }

        // Check to see if SeedAudience property is set
        internal bool IsSetSeedAudience()
        {
            return this._seedAudience != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The optional metadata that you apply to the resource to help you categorize and organize
        /// them. Each tag consists of a key and an optional value, both of which you define.
        /// </para>
        ///  
        /// <para>
        /// The following basic restrictions apply to tags:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Maximum number of tags per resource - 50.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For each resource, each tag key must be unique, and each tag key can have only one
        /// value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Maximum key length - 128 Unicode characters in UTF-8.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Maximum value length - 256 Unicode characters in UTF-8.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If your tagging schema is used across multiple services and resources, remember that
        /// other services may have restrictions on allowed characters. Generally allowed characters
        /// are: letters, numbers, and spaces representable in UTF-8, and the following characters:
        /// + - = . _ : / @.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Tag keys and values are case sensitive.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Do not use aws:, AWS:, or any upper or lowercase combination of such as a prefix for
        /// keys as it is reserved for AWS use. You cannot edit or delete tag keys with this prefix.
        /// Values can have this prefix. If a tag value has aws as its prefix but the key does
        /// not, then Clean Rooms ML considers it to be a user tag and will count against the
        /// limit of 50 tags. Tags with only the key prefix of aws do not count against your tags
        /// per resource limit.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}