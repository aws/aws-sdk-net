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
 * Do not modify this file. This file is generated from the dms-2016-01-01.normal.json service model.
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
    /// assessment run, given one or more parameters.
    /// 
    ///  
    /// <para>
    /// If you specify an existing migration task, this operation provides the default individual
    /// assessments you can specify for that task. Otherwise, the specified parameters model
    /// elements of a possible migration task on which to base a premigration assessment run.
    /// </para>
    ///  
    /// <para>
    /// To use these migration task modeling parameters, you must specify an existing replication
    /// instance, a source database engine, a target database engine, and a migration type.
    /// This combination of parameters potentially limits the default individual assessments
    /// available for an assessment run created for a corresponding migration task.
    /// </para>
    ///  
    /// <para>
    /// If you specify no parameters, this operation provides a list of all possible individual
    /// assessments that you can specify for an assessment run. If you specify any one of
    /// the task modeling parameters, you must specify all of them or the operation cannot
    /// provide a list of individual assessments. The only parameter that you can specify
    /// alone is for an existing migration task. The specified task definition then determines
    /// the default list of individual assessments that you can specify in an assessment run
    /// for the task.
    /// </para>
    /// </summary>
    public partial class DescribeApplicableIndividualAssessmentsRequest : AmazonDatabaseMigrationServiceRequest
    {
        private string _marker;
        private int? _maxRecords;
        private MigrationTypeValue _migrationType;
        private string _replicationConfigArn;
        private string _replicationInstanceArn;
        private string _replicationTaskArn;
        private string _sourceEngineName;
        private string _targetEngineName;

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// Optional pagination token provided by a previous request. If this parameter is specified,
        /// the response includes only records beyond the marker, up to the value specified by
        /// <c>MaxRecords</c>.
        /// </para>
        /// </summary>
        public string Marker
        {
            get { return this._marker; }
            set { this._marker = value; }
        }

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this._marker != null;
        }

        /// <summary>
        /// Gets and sets the property MaxRecords. 
        /// <para>
        /// Maximum number of records to include in the response. If more records exist than the
        /// specified <c>MaxRecords</c> value, a pagination token called a marker is included
        /// in the response so that the remaining results can be retrieved.
        /// </para>
        /// </summary>
        public int? MaxRecords
        {
            get { return this._maxRecords; }
            set { this._maxRecords = value; }
        }

        // Check to see if MaxRecords property is set
        internal bool IsSetMaxRecords()
        {
            return this._maxRecords.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MigrationType. 
        /// <para>
        /// Name of the migration type that each provided individual assessment must support.
        /// </para>
        /// </summary>
        public MigrationTypeValue MigrationType
        {
            get { return this._migrationType; }
            set { this._migrationType = value; }
        }

        // Check to see if MigrationType property is set
        internal bool IsSetMigrationType()
        {
            return this._migrationType != null;
        }

        /// <summary>
        /// Gets and sets the property ReplicationConfigArn. 
        /// <para>
        /// Amazon Resource Name (ARN) of a serverless replication on which you want to base the
        /// default list of individual assessments.
        /// </para>
        /// </summary>
        public string ReplicationConfigArn
        {
            get { return this._replicationConfigArn; }
            set { this._replicationConfigArn = value; }
        }

        // Check to see if ReplicationConfigArn property is set
        internal bool IsSetReplicationConfigArn()
        {
            return this._replicationConfigArn != null;
        }

        /// <summary>
        /// Gets and sets the property ReplicationInstanceArn. 
        /// <para>
        /// ARN of a replication instance on which you want to base the default list of individual
        /// assessments.
        /// </para>
        /// </summary>
        public string ReplicationInstanceArn
        {
            get { return this._replicationInstanceArn; }
            set { this._replicationInstanceArn = value; }
        }

        // Check to see if ReplicationInstanceArn property is set
        internal bool IsSetReplicationInstanceArn()
        {
            return this._replicationInstanceArn != null;
        }

        /// <summary>
        /// Gets and sets the property ReplicationTaskArn. 
        /// <para>
        /// Amazon Resource Name (ARN) of a migration task on which you want to base the default
        /// list of individual assessments.
        /// </para>
        /// </summary>
        public string ReplicationTaskArn
        {
            get { return this._replicationTaskArn; }
            set { this._replicationTaskArn = value; }
        }

        // Check to see if ReplicationTaskArn property is set
        internal bool IsSetReplicationTaskArn()
        {
            return this._replicationTaskArn != null;
        }

        /// <summary>
        /// Gets and sets the property SourceEngineName. 
        /// <para>
        /// Name of a database engine that the specified replication instance supports as a source.
        /// </para>
        /// </summary>
        public string SourceEngineName
        {
            get { return this._sourceEngineName; }
            set { this._sourceEngineName = value; }
        }

        // Check to see if SourceEngineName property is set
        internal bool IsSetSourceEngineName()
        {
            return this._sourceEngineName != null;
        }

        /// <summary>
        /// Gets and sets the property TargetEngineName. 
        /// <para>
        /// Name of a database engine that the specified replication instance supports as a target.
        /// </para>
        /// </summary>
        public string TargetEngineName
        {
            get { return this._targetEngineName; }
            set { this._targetEngineName = value; }
        }

        // Check to see if TargetEngineName property is set
        internal bool IsSetTargetEngineName()
        {
            return this._targetEngineName != null;
        }

    }
}