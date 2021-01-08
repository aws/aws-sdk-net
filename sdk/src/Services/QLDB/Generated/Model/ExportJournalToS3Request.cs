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
 * Do not modify this file. This file is generated from the qldb-2019-01-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.QLDB.Model
{
    /// <summary>
    /// Container for the parameters to the ExportJournalToS3 operation.
    /// Exports journal contents within a date and time range from a ledger into a specified
    /// Amazon Simple Storage Service (Amazon S3) bucket. The data is written as files in
    /// Amazon Ion format.
    /// 
    ///  
    /// <para>
    /// If the ledger with the given <code>Name</code> doesn't exist, then throws <code>ResourceNotFoundException</code>.
    /// </para>
    ///  
    /// <para>
    /// If the ledger with the given <code>Name</code> is in <code>CREATING</code> status,
    /// then throws <code>ResourcePreconditionNotMetException</code>.
    /// </para>
    ///  
    /// <para>
    /// You can initiate up to two concurrent journal export requests for each ledger. Beyond
    /// this limit, journal export requests throw <code>LimitExceededException</code>.
    /// </para>
    /// </summary>
    public partial class ExportJournalToS3Request : AmazonQLDBRequest
    {
        private DateTime? _exclusiveEndTime;
        private DateTime? _inclusiveStartTime;
        private string _name;
        private string _roleArn;
        private S3ExportConfiguration _s3ExportConfiguration;

        /// <summary>
        /// Gets and sets the property ExclusiveEndTime. 
        /// <para>
        /// The exclusive end date and time for the range of journal contents that you want to
        /// export.
        /// </para>
        ///  
        /// <para>
        /// The <code>ExclusiveEndTime</code> must be in <code>ISO 8601</code> date and time format
        /// and in Universal Coordinated Time (UTC). For example: <code>2019-06-13T21:36:34Z</code>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The <code>ExclusiveEndTime</code> must be less than or equal to the current UTC date
        /// and time.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime ExclusiveEndTime
        {
            get { return this._exclusiveEndTime.GetValueOrDefault(); }
            set { this._exclusiveEndTime = value; }
        }

        // Check to see if ExclusiveEndTime property is set
        internal bool IsSetExclusiveEndTime()
        {
            return this._exclusiveEndTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InclusiveStartTime. 
        /// <para>
        /// The inclusive start date and time for the range of journal contents that you want
        /// to export.
        /// </para>
        ///  
        /// <para>
        /// The <code>InclusiveStartTime</code> must be in <code>ISO 8601</code> date and time
        /// format and in Universal Coordinated Time (UTC). For example: <code>2019-06-13T21:36:34Z</code>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The <code>InclusiveStartTime</code> must be before <code>ExclusiveEndTime</code>.
        /// </para>
        ///  
        /// <para>
        /// If you provide an <code>InclusiveStartTime</code> that is before the ledger's <code>CreationDateTime</code>,
        /// Amazon QLDB defaults it to the ledger's <code>CreationDateTime</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime InclusiveStartTime
        {
            get { return this._inclusiveStartTime.GetValueOrDefault(); }
            set { this._inclusiveStartTime = value; }
        }

        // Check to see if InclusiveStartTime property is set
        internal bool IsSetInclusiveStartTime()
        {
            return this._inclusiveStartTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the ledger.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=32)]
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
        /// The Amazon Resource Name (ARN) of the IAM role that grants QLDB permissions for a
        /// journal export job to do the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Write objects into your Amazon Simple Storage Service (Amazon S3) bucket.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// (Optional) Use your customer master key (CMK) in AWS Key Management Service (AWS KMS)
        /// for server-side encryption of your exported data.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=1600)]
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
        /// Gets and sets the property S3ExportConfiguration. 
        /// <para>
        /// The configuration settings of the Amazon S3 bucket destination for your export request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public S3ExportConfiguration S3ExportConfiguration
        {
            get { return this._s3ExportConfiguration; }
            set { this._s3ExportConfiguration = value; }
        }

        // Check to see if S3ExportConfiguration property is set
        internal bool IsSetS3ExportConfiguration()
        {
            return this._s3ExportConfiguration != null;
        }

    }
}