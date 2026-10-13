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

namespace Amazon.Glue.Model
{
    /// <summary>
    /// This is the response object from the CreateDevEndpoint operation.
    /// </summary>
    public partial class CreateDevEndpointResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Arguments. 
        /// <para>
        /// The map of arguments used to configure this <c>DevEndpoint</c>.
        /// </para>
        ///  
        /// <para>
        /// Valid arguments are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>"--enable-glue-datacatalog": ""</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You can specify a version of Python support for development endpoints by using the
        /// <c>Arguments</c> parameter in the <c>CreateDevEndpoint</c> or <c>UpdateDevEndpoint</c>
        /// APIs. If no arguments are provided, the version defaults to Python 2.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public Dictionary<string, string> Arguments { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Arguments property is set.
        /// </summary>
        internal bool IsSetArguments() => this.Arguments != null && (this.Arguments.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The Amazon Web Services Availability Zone where this <c>DevEndpoint</c> is located.
        /// </para>
        /// </summary>
        public string AvailabilityZone { get; set; }

        /// <summary>
        /// Checks to see if the AvailabilityZone property is set.
        /// </summary>
        internal bool IsSetAvailabilityZone() => this.AvailabilityZone != null;

        /// <summary>
        /// Gets and sets the property CreatedTimestamp. 
        /// <para>
        /// The point in time at which this <c>DevEndpoint</c> was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the CreatedTimestamp property is set.
        /// </summary>
        internal bool IsSetCreatedTimestamp() => this.CreatedTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property EndpointName. 
        /// <para>
        /// The name assigned to the new <c>DevEndpoint</c>.
        /// </para>
        /// </summary>
        public string EndpointName { get; set; }

        /// <summary>
        /// Checks to see if the EndpointName property is set.
        /// </summary>
        internal bool IsSetEndpointName() => this.EndpointName != null;

        /// <summary>
        /// Gets and sets the property ExtraJarsS3Path. 
        /// <para>
        /// Path to one or more Java <c>.jar</c> files in an S3 bucket that will be loaded in
        /// your <c>DevEndpoint</c>.
        /// </para>
        /// </summary>
        public string ExtraJarsS3Path { get; set; }

        /// <summary>
        /// Checks to see if the ExtraJarsS3Path property is set.
        /// </summary>
        internal bool IsSetExtraJarsS3Path() => this.ExtraJarsS3Path != null;

        /// <summary>
        /// Gets and sets the property ExtraPythonLibsS3Path. 
        /// <para>
        /// The paths to one or more Python libraries in an S3 bucket that will be loaded in your
        /// <c>DevEndpoint</c>.
        /// </para>
        /// </summary>
        public string ExtraPythonLibsS3Path { get; set; }

        /// <summary>
        /// Checks to see if the ExtraPythonLibsS3Path property is set.
        /// </summary>
        internal bool IsSetExtraPythonLibsS3Path() => this.ExtraPythonLibsS3Path != null;

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// The reason for a current failure in this <c>DevEndpoint</c>.
        /// </para>
        /// </summary>
        public string FailureReason { get; set; }

        /// <summary>
        /// Checks to see if the FailureReason property is set.
        /// </summary>
        internal bool IsSetFailureReason() => this.FailureReason != null;

        /// <summary>
        /// Gets and sets the property GlueVersion. 
        /// <para>
        /// Glue version determines the versions of Apache Spark and Python that Glue supports.
        /// The Python version indicates the version supported for running your ETL scripts on
        /// development endpoints. 
        /// </para>
        ///  
        /// <para>
        /// For more information about the available Glue versions and corresponding Spark and
        /// Python versions, see <a href="https://docs.aws.amazon.com/glue/latest/dg/add-job.html">Glue
        /// version</a> in the developer guide.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string GlueVersion { get; set; }

        /// <summary>
        /// Checks to see if the GlueVersion property is set.
        /// </summary>
        internal bool IsSetGlueVersion() => this.GlueVersion != null;

        /// <summary>
        /// Gets and sets the property NumberOfNodes. 
        /// <para>
        /// The number of Glue Data Processing Units (DPUs) allocated to this DevEndpoint.
        /// </para>
        /// </summary>
        public int? NumberOfNodes { get; set; }

        /// <summary>
        /// Checks to see if the NumberOfNodes property is set.
        /// </summary>
        internal bool IsSetNumberOfNodes() => this.NumberOfNodes.HasValue;

        /// <summary>
        /// Gets and sets the property NumberOfWorkers. 
        /// <para>
        /// The number of workers of a defined <c>workerType</c> that are allocated to the development
        /// endpoint.
        /// </para>
        /// </summary>
        public int? NumberOfWorkers { get; set; }

        /// <summary>
        /// Checks to see if the NumberOfWorkers property is set.
        /// </summary>
        internal bool IsSetNumberOfWorkers() => this.NumberOfWorkers.HasValue;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the role assigned to the new <c>DevEndpoint</c>.
        /// </para>
        /// </summary>
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property SecurityConfiguration. 
        /// <para>
        /// The name of the <c>SecurityConfiguration</c> structure being used with this <c>DevEndpoint</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string SecurityConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the SecurityConfiguration property is set.
        /// </summary>
        internal bool IsSetSecurityConfiguration() => this.SecurityConfiguration != null;

        /// <summary>
        /// Gets and sets the property SecurityGroupIds. 
        /// <para>
        /// The security groups assigned to the new <c>DevEndpoint</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SecurityGroupIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SecurityGroupIds property is set.
        /// </summary>
        internal bool IsSetSecurityGroupIds() => this.SecurityGroupIds != null && (this.SecurityGroupIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the new <c>DevEndpoint</c>.
        /// </para>
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property SubnetId. 
        /// <para>
        /// The subnet ID assigned to the new <c>DevEndpoint</c>.
        /// </para>
        /// </summary>
        public string SubnetId { get; set; }

        /// <summary>
        /// Checks to see if the SubnetId property is set.
        /// </summary>
        internal bool IsSetSubnetId() => this.SubnetId != null;

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The ID of the virtual private cloud (VPC) used by this <c>DevEndpoint</c>.
        /// </para>
        /// </summary>
        public string VpcId { get; set; }

        /// <summary>
        /// Checks to see if the VpcId property is set.
        /// </summary>
        internal bool IsSetVpcId() => this.VpcId != null;

        /// <summary>
        /// Gets and sets the property WorkerType. 
        /// <para>
        /// The type of predefined worker that is allocated to the development endpoint. May be
        /// a value of Standard, G.1X, or G.2X.
        /// </para>
        /// </summary>
        public WorkerType WorkerType { get; set; }

        /// <summary>
        /// Checks to see if the WorkerType property is set.
        /// </summary>
        internal bool IsSetWorkerType() => this.WorkerType != null;

        /// <summary>
        /// Gets and sets the property YarnEndpointAddress. 
        /// <para>
        /// The address of the YARN endpoint used by this <c>DevEndpoint</c>.
        /// </para>
        /// </summary>
        public string YarnEndpointAddress { get; set; }

        /// <summary>
        /// Checks to see if the YarnEndpointAddress property is set.
        /// </summary>
        internal bool IsSetYarnEndpointAddress() => this.YarnEndpointAddress != null;

        /// <summary>
        /// Gets and sets the property ZeppelinRemoteSparkInterpreterPort. 
        /// <para>
        /// The Apache Zeppelin port for the remote Apache Spark interpreter.
        /// </para>
        /// </summary>
        public int? ZeppelinRemoteSparkInterpreterPort { get; set; }

        /// <summary>
        /// Checks to see if the ZeppelinRemoteSparkInterpreterPort property is set.
        /// </summary>
        internal bool IsSetZeppelinRemoteSparkInterpreterPort() => this.ZeppelinRemoteSparkInterpreterPort.HasValue;
    }
}
