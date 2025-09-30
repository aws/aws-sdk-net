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
 * Do not modify this file. This file is generated from the application-signals-2024-04-15.normal.json service model.
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
namespace Amazon.ApplicationSignals.Model
{
    /// <summary>
    /// This structure contains information about one of your services that was discovered
    /// by Application Signals
    /// </summary>
    public partial class ServiceSummary
    {
        private List<Dictionary<string, string>> _attributeMaps = AWSConfigs.InitializeCollections ? new List<Dictionary<string, string>>() : null;
        private Dictionary<string, string> _keyAttributes = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private List<MetricReference> _metricReferences = AWSConfigs.InitializeCollections ? new List<MetricReference>() : null;
        private List<ServiceGroup> _serviceGroups = AWSConfigs.InitializeCollections ? new List<ServiceGroup>() : null;

        /// <summary>
        /// Gets and sets the property AttributeMaps. 
        /// <para>
        /// This structure contains one or more string-to-string maps that help identify this
        /// service. It can include <i>platform attributes</i>, <i>application attributes</i>,
        /// and <i>telemetry attributes</i>.
        /// </para>
        ///  
        /// <para>
        /// Platform attributes contain information the service's platform.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>PlatformType</c> defines the hosted-in platform.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>EKS.Cluster</c> is the name of the Amazon EKS cluster.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>K8s.Cluster</c> is the name of the self-hosted Kubernetes cluster.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>K8s.Namespace</c> is the name of the Kubernetes namespace in either Amazon EKS
        /// or Kubernetes clusters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>K8s.Workload</c> is the name of the Kubernetes workload in either Amazon EKS or
        /// Kubernetes clusters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>K8s.Node</c> is the name of the Kubernetes node in either Amazon EKS or Kubernetes
        /// clusters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>K8s.Pod</c> is the name of the Kubernetes pod in either Amazon EKS or Kubernetes
        /// clusters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>EC2.AutoScalingGroup</c> is the name of the Amazon EC2 Auto Scaling group.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>EC2.InstanceId</c> is the ID of the Amazon EC2 instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Host</c> is the name of the host, for all platform types.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Application attributes contain information about the application.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>AWS.Application</c> is the application's name in Amazon Web Services Service Catalog
        /// AppRegistry.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS.Application.ARN</c> is the application's ARN in Amazon Web Services Service
        /// Catalog AppRegistry.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Telemetry attributes contain telemetry information.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Telemetry.SDK</c> is the fingerprint of the OpenTelemetry SDK version for instrumented
        /// services.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Telemetry.Agent</c> is the fingerprint of the agent used to collect and send telemetry
        /// data.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Telemetry.Source</c> Specifies the point of application where the telemetry was
        /// collected or specifies what was used for the source of telemetry data.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Dictionary<string, string>> AttributeMaps
        {
            get { return this._attributeMaps; }
            set { this._attributeMaps = value; }
        }

        // Check to see if AttributeMaps property is set
        internal bool IsSetAttributeMaps()
        {
            return this._attributeMaps != null && (this._attributeMaps.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property KeyAttributes. 
        /// <para>
        /// This is a string-to-string map that help identify the objects discovered by Application
        /// Signals. It can include the following fields.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Type</c> designates the type of object this is.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ResourceType</c> specifies the type of the resource. This field is used only when
        /// the value of the <c>Type</c> field is <c>Resource</c> or <c>AWS::Resource</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Name</c> specifies the name of the object. This is used only if the value of the
        /// <c>Type</c> field is <c>Service</c>, <c>RemoteService</c>, or <c>AWS::Service</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Identifier</c> identifies the resource objects of this resource. This is used
        /// only if the value of the <c>Type</c> field is <c>Resource</c> or <c>AWS::Resource</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Environment</c> specifies the location where this object is hosted, or what it
        /// belongs to.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=4)]
        public Dictionary<string, string> KeyAttributes
        {
            get { return this._keyAttributes; }
            set { this._keyAttributes = value; }
        }

        // Check to see if KeyAttributes property is set
        internal bool IsSetKeyAttributes()
        {
            return this._keyAttributes != null && (this._keyAttributes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MetricReferences. 
        /// <para>
        /// An array of structures that each contain information about one metric associated with
        /// this service.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<MetricReference> MetricReferences
        {
            get { return this._metricReferences; }
            set { this._metricReferences = value; }
        }

        // Check to see if MetricReferences property is set
        internal bool IsSetMetricReferences()
        {
            return this._metricReferences != null && (this._metricReferences.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ServiceGroups. 
        /// <para>
        /// An array of service groups that this service belongs to, based on the configured grouping
        /// attributes.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ServiceGroup> ServiceGroups
        {
            get { return this._serviceGroups; }
            set { this._serviceGroups = value; }
        }

        // Check to see if ServiceGroups property is set
        internal bool IsSetServiceGroups()
        {
            return this._serviceGroups != null && (this._serviceGroups.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}