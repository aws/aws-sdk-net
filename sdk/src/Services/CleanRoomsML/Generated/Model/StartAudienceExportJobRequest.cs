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
    /// Container for the parameters to the StartAudienceExportJob operation.
    /// Export an audience of a specified size after you have generated an audience.
    /// </summary>
    public partial class StartAudienceExportJobRequest : AmazonCleanRoomsMLRequest
    {
        private string _audienceGenerationJobArn;
        private AudienceSize _audienceSize;
        private string _description;
        private string _name;

        /// <summary>
        /// Gets and sets the property AudienceGenerationJobArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the audience generation job that you want to export.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string AudienceGenerationJobArn
        {
            get { return this._audienceGenerationJobArn; }
            set { this._audienceGenerationJobArn = value; }
        }

        // Check to see if AudienceGenerationJobArn property is set
        internal bool IsSetAudienceGenerationJobArn()
        {
            return this._audienceGenerationJobArn != null;
        }

        /// <summary>
        /// Gets and sets the property AudienceSize.
        /// </summary>
        [AWSProperty(Required=true)]
        public AudienceSize AudienceSize
        {
            get { return this._audienceSize; }
            set { this._audienceSize = value; }
        }

        // Check to see if AudienceSize property is set
        internal bool IsSetAudienceSize()
        {
            return this._audienceSize != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the audience export job.
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
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the audience export job.
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

    }
}