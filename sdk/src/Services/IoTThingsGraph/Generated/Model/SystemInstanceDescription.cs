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
 * Do not modify this file. This file is generated from the iotthingsgraph-2018-09-06.normal.json service model.
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
namespace Amazon.IoTThingsGraph.Model
{
    /// <summary>
    /// An object that contains a system instance definition and summary information.
    /// </summary>
    public partial class SystemInstanceDescription
    {
        private DefinitionDocument _definition;
        private string _flowActionsRoleArn;
        private MetricsConfiguration _metricsConfiguration;
        private string _s3BucketName;
        private SystemInstanceSummary _summary;
        private List<DependencyRevision> _validatedDependencyRevisions = AWSConfigs.InitializeCollections ? new List<DependencyRevision>() : null;
        private long? _validatedNamespaceVersion;

        /// <summary>
        /// Gets and sets the property Definition.
        /// </summary>
        public DefinitionDocument Definition
        {
            get { return this._definition; }
            set { this._definition = value; }
        }

        // Check to see if Definition property is set
        internal bool IsSetDefinition()
        {
            return this._definition != null;
        }

        /// <summary>
        /// Gets and sets the property FlowActionsRoleArn. 
        /// <para>
        /// The AWS Identity and Access Management (IAM) role that AWS IoT Things Graph assumes
        /// during flow execution in a cloud deployment. This role must have read and write permissionss
        /// to AWS Lambda and AWS IoT and to any other AWS services that the flow uses.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string FlowActionsRoleArn
        {
            get { return this._flowActionsRoleArn; }
            set { this._flowActionsRoleArn = value; }
        }

        // Check to see if FlowActionsRoleArn property is set
        internal bool IsSetFlowActionsRoleArn()
        {
            return this._flowActionsRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property MetricsConfiguration.
        /// </summary>
        public MetricsConfiguration MetricsConfiguration
        {
            get { return this._metricsConfiguration; }
            set { this._metricsConfiguration = value; }
        }

        // Check to see if MetricsConfiguration property is set
        internal bool IsSetMetricsConfiguration()
        {
            return this._metricsConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property S3BucketName. 
        /// <para>
        /// The Amazon Simple Storage Service bucket where information about a system instance
        /// is stored.
        /// </para>
        /// </summary>
        public string S3BucketName
        {
            get { return this._s3BucketName; }
            set { this._s3BucketName = value; }
        }

        // Check to see if S3BucketName property is set
        internal bool IsSetS3BucketName()
        {
            return this._s3BucketName != null;
        }

        /// <summary>
        /// Gets and sets the property Summary. 
        /// <para>
        /// An object that contains summary information about a system instance.
        /// </para>
        /// </summary>
        public SystemInstanceSummary Summary
        {
            get { return this._summary; }
            set { this._summary = value; }
        }

        // Check to see if Summary property is set
        internal bool IsSetSummary()
        {
            return this._summary != null;
        }

        /// <summary>
        /// Gets and sets the property ValidatedDependencyRevisions. 
        /// <para>
        /// A list of objects that contain all of the IDs and revision numbers of workflows and
        /// systems that are used in a system instance.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DependencyRevision> ValidatedDependencyRevisions
        {
            get { return this._validatedDependencyRevisions; }
            set { this._validatedDependencyRevisions = value; }
        }

        // Check to see if ValidatedDependencyRevisions property is set
        internal bool IsSetValidatedDependencyRevisions()
        {
            return this._validatedDependencyRevisions != null && (this._validatedDependencyRevisions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ValidatedNamespaceVersion. 
        /// <para>
        /// The version of the user's namespace against which the system instance was validated.
        /// </para>
        /// </summary>
        public long? ValidatedNamespaceVersion
        {
            get { return this._validatedNamespaceVersion; }
            set { this._validatedNamespaceVersion = value; }
        }

        // Check to see if ValidatedNamespaceVersion property is set
        internal bool IsSetValidatedNamespaceVersion()
        {
            return this._validatedNamespaceVersion.HasValue; 
        }

    }
}