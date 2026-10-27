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

namespace Amazon.DatabaseMigrationService.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeApplicableIndividualAssessments operation.
    /// Provides a list of individual assessments that you can specify for a new premigration
    /// assessment run, given one or more parameters. <para> If you specify an existing migration
    /// task, this operation provides the default individual assessments you can specify for
    /// that task. Otherwise, the specified parameters model elements of a possible migration
    /// task on which to base a premigration assessment run. </para> <para> To use these migration
    /// task modeling parameters, you must specify an existing replication instance, a source
    /// database engine, a target database engine, and a migration type. This combination
    /// of parameters potentially limits the default individual assessments available for
    /// an assessment run created for a corresponding migration task. </para> <para> If you
    /// specify no parameters, this operation provides a list of all possible individual assessments
    /// that you can specify for an assessment run. If you specify any one of the task modeling
    /// parameters, you must specify all of them or the operation cannot provide a list of
    /// individual assessments. The only parameter that you can specify alone is for an existing
    /// migration task. The specified task definition then determines the default list of
    /// individual assessments that you can specify in an assessment run for the task. </para>
    /// </summary>
    public partial class DescribeApplicableIndividualAssessmentsRequest : AmazonDatabaseMigrationServiceRequest
    {
        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// Optional pagination token provided by a previous request. If this parameter is specified,
        /// the response includes only records beyond the marker, up to the value specified by
        /// <c>MaxRecords</c>.
        /// </para>
        /// </summary>
        public string Marker { get; set; }

        /// <summary>
        /// Checks to see if the Marker property is set.
        /// </summary>
        internal bool IsSetMarker() => this.Marker != null;

        /// <summary>
        /// Gets and sets the property MaxRecords. 
        /// <para>
        /// Maximum number of records to include in the response. If more records exist than the
        /// specified <c>MaxRecords</c> value, a pagination token called a marker is included
        /// in the response so that the remaining results can be retrieved.
        /// </para>
        /// </summary>
        public int? MaxRecords { get; set; }

        /// <summary>
        /// Checks to see if the MaxRecords property is set.
        /// </summary>
        internal bool IsSetMaxRecords() => this.MaxRecords.HasValue;

        /// <summary>
        /// Gets and sets the property MigrationType. 
        /// <para>
        /// Name of the migration type that each provided individual assessment must support.
        /// </para>
        /// </summary>
        public MigrationTypeValue MigrationType { get; set; }

        /// <summary>
        /// Checks to see if the MigrationType property is set.
        /// </summary>
        internal bool IsSetMigrationType() => this.MigrationType != null;

        /// <summary>
        /// Gets and sets the property ReplicationConfigArn. 
        /// <para>
        /// Amazon Resource Name (ARN) of a serverless replication on which you want to base the
        /// default list of individual assessments.
        /// </para>
        /// </summary>
        public string ReplicationConfigArn { get; set; }

        /// <summary>
        /// Checks to see if the ReplicationConfigArn property is set.
        /// </summary>
        internal bool IsSetReplicationConfigArn() => this.ReplicationConfigArn != null;

        /// <summary>
        /// Gets and sets the property ReplicationInstanceArn. 
        /// <para>
        /// ARN of a replication instance on which you want to base the default list of individual
        /// assessments.
        /// </para>
        /// </summary>
        public string ReplicationInstanceArn { get; set; }

        /// <summary>
        /// Checks to see if the ReplicationInstanceArn property is set.
        /// </summary>
        internal bool IsSetReplicationInstanceArn() => this.ReplicationInstanceArn != null;

        /// <summary>
        /// Gets and sets the property ReplicationTaskArn. 
        /// <para>
        /// Amazon Resource Name (ARN) of a migration task on which you want to base the default
        /// list of individual assessments.
        /// </para>
        /// </summary>
        public string ReplicationTaskArn { get; set; }

        /// <summary>
        /// Checks to see if the ReplicationTaskArn property is set.
        /// </summary>
        internal bool IsSetReplicationTaskArn() => this.ReplicationTaskArn != null;

        /// <summary>
        /// Gets and sets the property SourceEngineName. 
        /// <para>
        /// Name of a database engine that the specified replication instance supports as a source.
        /// </para>
        /// </summary>
        public string SourceEngineName { get; set; }

        /// <summary>
        /// Checks to see if the SourceEngineName property is set.
        /// </summary>
        internal bool IsSetSourceEngineName() => this.SourceEngineName != null;

        /// <summary>
        /// Gets and sets the property TargetEngineName. 
        /// <para>
        /// Name of a database engine that the specified replication instance supports as a target.
        /// </para>
        /// </summary>
        public string TargetEngineName { get; set; }

        /// <summary>
        /// Checks to see if the TargetEngineName property is set.
        /// </summary>
        internal bool IsSetTargetEngineName() => this.TargetEngineName != null;
    }
}
