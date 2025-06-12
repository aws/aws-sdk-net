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
 * Do not modify this file. This file is generated from the simspaceweaver-2022-10-28.normal.json service model.
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
namespace Amazon.SimSpaceWeaver.Model
{
    /// <summary>
    /// Container for the parameters to the StartSimulation operation.
    /// Starts a simulation with the given name. You must choose to start your simulation
    /// from a schema or from a snapshot. For more information about the schema, see the <a
    /// href="https://docs.aws.amazon.com/simspaceweaver/latest/userguide/schema-reference.html">schema
    /// reference</a> in the <i>SimSpace Weaver User Guide</i>. For more information about
    /// snapshots, see <a href="https://docs.aws.amazon.com/simspaceweaver/latest/userguide/working-with_snapshots.html">Snapshots</a>
    /// in the <i>SimSpace Weaver User Guide</i>.
    /// </summary>
    public partial class StartSimulationRequest : AmazonSimSpaceWeaverRequest
    {
        private string _clientToken;
        private string _description;
        private string _maximumDuration;
        private string _name;
        private string _roleArn;
        private S3Location _schemaS3Location;
        private S3Location _snapshotS3Location;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A value that you provide to ensure that repeated calls to this API operation using
        /// the same parameters complete only once. A <c>ClientToken</c> is also known as an <i>idempotency
        /// token</i>. A <c>ClientToken</c> expires after 24 hours.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=32, Max=128)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the simulation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=500)]
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
        /// Gets and sets the property MaximumDuration. 
        /// <para>
        /// The maximum running time of the simulation, specified as a number of minutes (m or
        /// M), hours (h or H), or days (d or D). The simulation stops when it reaches this limit.
        /// The maximum value is <c>14D</c>, or its equivalent in the other units. The default
        /// value is <c>14D</c>. A value equivalent to <c>0</c> makes the simulation immediately
        /// transition to <c>Stopping</c> as soon as it reaches <c>Started</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=6)]
        public string MaximumDuration
        {
            get { return this._maximumDuration; }
            set { this._maximumDuration = value; }
        }

        // Check to see if MaximumDuration property is set
        internal bool IsSetMaximumDuration()
        {
            return this._maximumDuration != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the simulation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
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
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Identity and Access Management (IAM) role that
        /// the simulation assumes to perform actions. For more information about ARNs, see <a
        /// href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Names (ARNs)</a> in the <i>Amazon Web Services General Reference</i>. For
        /// more information about IAM roles, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles.html">IAM
        /// roles</a> in the <i>Identity and Access Management User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1600)]
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

        /// <summary>
        /// Gets and sets the property SchemaS3Location. 
        /// <para>
        /// The location of the simulation schema in Amazon Simple Storage Service (Amazon S3).
        /// For more information about Amazon S3, see the <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/Welcome.html">
        /// <i>Amazon Simple Storage Service User Guide</i> </a>.
        /// </para>
        ///  
        /// <para>
        /// Provide a <c>SchemaS3Location</c> to start your simulation from a schema.
        /// </para>
        ///  
        /// <para>
        /// If you provide a <c>SchemaS3Location</c> then you can't provide a <c>SnapshotS3Location</c>.
        /// </para>
        /// </summary>
        public S3Location SchemaS3Location
        {
            get { return this._schemaS3Location; }
            set { this._schemaS3Location = value; }
        }

        // Check to see if SchemaS3Location property is set
        internal bool IsSetSchemaS3Location()
        {
            return this._schemaS3Location != null;
        }

        /// <summary>
        /// Gets and sets the property SnapshotS3Location. 
        /// <para>
        /// The location of the snapshot .zip file in Amazon Simple Storage Service (Amazon S3).
        /// For more information about Amazon S3, see the <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/Welcome.html">
        /// <i>Amazon Simple Storage Service User Guide</i> </a>.
        /// </para>
        ///  
        /// <para>
        /// Provide a <c>SnapshotS3Location</c> to start your simulation from a snapshot.
        /// </para>
        ///  
        /// <para>
        /// The Amazon S3 bucket must be in the same Amazon Web Services Region as the simulation.
        /// </para>
        ///  
        /// <para>
        /// If you provide a <c>SnapshotS3Location</c> then you can't provide a <c>SchemaS3Location</c>.
        /// </para>
        /// </summary>
        public S3Location SnapshotS3Location
        {
            get { return this._snapshotS3Location; }
            set { this._snapshotS3Location = value; }
        }

        // Check to see if SnapshotS3Location property is set
        internal bool IsSetSnapshotS3Location()
        {
            return this._snapshotS3Location != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of tags for the simulation. For more information about tags, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html">Tagging
        /// Amazon Web Services resources</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
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