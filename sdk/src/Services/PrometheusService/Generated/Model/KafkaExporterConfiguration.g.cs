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

namespace Amazon.PrometheusService.Model
{
    /// <summary>
    /// The configuration for collecting broker, topic, and consumer-group metrics from an
    /// Amazon MSK cluster through a managed Kafka exporter. The cluster must be active, have
    /// IAM authentication enabled, and be in the same account and Region as the scraper.
    /// Provisioned clusters with Standard brokers are supported. MSK Serverless clusters
    /// are not supported.
    /// 
    ///  
    /// <para>
    /// Use a VPC source that can connect to the cluster's IAM bootstrap brokers. The exporter
    /// authenticates with the scraper's service-linked role. Metrics can be sent to an Amazon
    /// Managed Service for Prometheus workspace or a CloudWatch dataset.
    /// </para>
    ///  
    /// <para>
    /// You must have an Amazon MSK cluster policy that grants the scraper's service-linked
    /// role access to the cluster. Without this policy, the scraper collects no Kafka metrics.
    /// For the required actions and example policies, see <a href="https://docs.aws.amazon.com/prometheus/latest/userguide/prom-msk-kafka-exporter.html#prom-msk-kafka-exporter-access">Grant
    /// the scraper access to the cluster</a> in the <i>Amazon Managed Service for Prometheus
    /// User Guide</i>.
    /// </para>
    /// </summary>
    public partial class KafkaExporterConfiguration
    {
        /// <summary>
        /// Gets and sets the property ClusterArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon MSK cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ClusterArn { get; set; }

        /// <summary>
        /// Checks to see if the ClusterArn property is set.
        /// </summary>
        internal bool IsSetClusterArn() => this.ClusterArn != null;

        /// <summary>
        /// Gets and sets the property ConsumerGroupFilter. 
        /// <para>
        /// An anchored RE2 regular expression that selects the Kafka consumer groups to monitor.
        /// The expression must start with <c>^</c> and end with <c>$</c>. If omitted, the default
        /// is <c>^.*$</c>, which selects all consumer groups.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string ConsumerGroupFilter { get; set; }

        /// <summary>
        /// Checks to see if the ConsumerGroupFilter property is set.
        /// </summary>
        internal bool IsSetConsumerGroupFilter() => this.ConsumerGroupFilter != null;

        /// <summary>
        /// Gets and sets the property TopicFilter. 
        /// <para>
        /// An anchored RE2 regular expression that selects the Kafka topics to monitor. The expression
        /// must start with <c>^</c> and end with <c>$</c>. If omitted, the default is <c>^.*$</c>,
        /// which selects all topics.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string TopicFilter { get; set; }

        /// <summary>
        /// Checks to see if the TopicFilter property is set.
        /// </summary>
        internal bool IsSetTopicFilter() => this.TopicFilter != null;
    }
}
