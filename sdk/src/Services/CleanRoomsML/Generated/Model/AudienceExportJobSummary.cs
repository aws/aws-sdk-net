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
    /// Provides information about the audience export job.
    /// </summary>
    public partial class AudienceExportJobSummary
    {
        private string _audienceGenerationJobArn;
        private AudienceSize _audienceSize;
        private DateTime? _createTime;
        private string _description;
        private string _name;
        private string _outputLocation;
        private AudienceExportJobStatus _status;
        private StatusDetails _statusDetails;
        private DateTime? _updateTime;

        /// <summary>
        /// Gets and sets the property AudienceGenerationJobArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the audience generation job that was exported.
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
        /// Gets and sets the property CreateTime. 
        /// <para>
        /// The time at which the audience export job was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreateTime
        {
            get { return this._createTime; }
            set { this._createTime = value; }
        }

        // Check to see if CreateTime property is set
        internal bool IsSetCreateTime()
        {
            return this._createTime.HasValue; 
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

        /// <summary>
        /// Gets and sets the property OutputLocation. 
        /// <para>
        /// The Amazon S3 bucket where the audience export is stored.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1285)]
        public string OutputLocation
        {
            get { return this._outputLocation; }
            set { this._outputLocation = value; }
        }

        // Check to see if OutputLocation property is set
        internal bool IsSetOutputLocation()
        {
            return this._outputLocation != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the audience export job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AudienceExportJobStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property StatusDetails.
        /// </summary>
        public StatusDetails StatusDetails
        {
            get { return this._statusDetails; }
            set { this._statusDetails = value; }
        }

        // Check to see if StatusDetails property is set
        internal bool IsSetStatusDetails()
        {
            return this._statusDetails != null;
        }

        /// <summary>
        /// Gets and sets the property UpdateTime. 
        /// <para>
        /// The most recent time at which the audience export job was updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? UpdateTime
        {
            get { return this._updateTime; }
            set { this._updateTime = value; }
        }

        // Check to see if UpdateTime property is set
        internal bool IsSetUpdateTime()
        {
            return this._updateTime.HasValue; 
        }

    }
}