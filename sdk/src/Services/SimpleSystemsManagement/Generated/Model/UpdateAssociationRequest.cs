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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateAssociation operation.
    /// Updates an association. You can only update the document version, schedule, parameters,
    /// and Amazon S3 output of an association.
    /// </summary>
    public partial class UpdateAssociationRequest : AmazonSimpleSystemsManagementRequest
    {
        private string _associationId;
        private string _documentVersion;
        private InstanceAssociationOutputLocation _outputLocation;
        private Dictionary<string, List<string>> _parameters = new Dictionary<string, List<string>>();
        private string _scheduleExpression;

        /// <summary>
        /// Gets and sets the property AssociationId. 
        /// <para>
        /// The ID of the association you want to update. 
        /// </para>
        /// </summary>
        public string AssociationId
        {
            get { return this._associationId; }
            set { this._associationId = value; }
        }

        // Check to see if AssociationId property is set
        internal bool IsSetAssociationId()
        {
            return this._associationId != null;
        }

        /// <summary>
        /// Gets and sets the property DocumentVersion. 
        /// <para>
        /// The document version you want update for the association. 
        /// </para>
        /// </summary>
        public string DocumentVersion
        {
            get { return this._documentVersion; }
            set { this._documentVersion = value; }
        }

        // Check to see if DocumentVersion property is set
        internal bool IsSetDocumentVersion()
        {
            return this._documentVersion != null;
        }

        /// <summary>
        /// Gets and sets the property OutputLocation. 
        /// <para>
        /// An Amazon S3 bucket where you want to store the results of this request.
        /// </para>
        ///  
        /// <para>
        ///  <code>"{ \"S3Location\": { \"OutputS3Region\": \"&lt;region&gt;\", \"OutputS3BucketName\":
        /// \"bucket name\", \"OutputS3KeyPrefix\": \"folder name\" } }"</code> 
        /// </para>
        /// </summary>
        public InstanceAssociationOutputLocation OutputLocation
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
        /// Gets and sets the property Parameters. 
        /// <para>
        /// The parameters you want to update for the association. If you create a parameter using
        /// Parameter Store, you can reference the parameter using {{ssm:parameter-name}}
        /// </para>
        /// </summary>
        public Dictionary<string, List<string>> Parameters
        {
            get { return this._parameters; }
            set { this._parameters = value; }
        }

        // Check to see if Parameters property is set
        internal bool IsSetParameters()
        {
            return this._parameters != null && this._parameters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ScheduleExpression. 
        /// <para>
        /// The cron expression used to schedule the association that you want to update. Supported
        /// expressions are every half, 1, 2, 4, 8 or 12 hour(s); every specified day and time
        /// of the week. For example: cron(0 0/30 * 1/1 * ? *) to run every thirty minutes; cron(0
        /// 0 0/4 1/1 * ? *) to run every four hours; and cron(0 0 10 ? * SUN *) to run every
        /// Sunday at 10 a.m.
        /// </para>
        /// </summary>
        public string ScheduleExpression
        {
            get { return this._scheduleExpression; }
            set { this._scheduleExpression = value; }
        }

        // Check to see if ScheduleExpression property is set
        internal bool IsSetScheduleExpression()
        {
            return this._scheduleExpression != null;
        }

    }
}