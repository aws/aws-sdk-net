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
 * Do not modify this file. This file is generated from the glacier-2012-06-01.normal.json service model.
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
namespace Amazon.Glacier.Model
{
    /// <summary>
    /// Provides options for defining a job.
    /// </summary>
    public partial class JobParameters
    {
        private string _archiveId;
        private string _description;
        private string _format;
        private InventoryRetrievalJobInput _inventoryRetrievalParameters;
        private OutputLocation _outputLocation;
        private string _retrievalByteRange;
        private SelectParameters _selectParameters;
        private string _snsTopic;
        private string _tier;
        private string _type;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public JobParameters() { }

        /// <summary>
        /// Instantiates JobParameters with the parameterized properties
        /// </summary>
        /// <param name="format">When initiating a job to retrieve a vault inventory, you can optionally add this parameter to your request to specify the output format. If you are initiating an inventory job and do not specify a Format field, JSON is the default format. Valid values are "CSV" and "JSON".</param>
        /// <param name="type">The job type. You can initiate a job to perform a select query on an archive, retrieve an archive, or get an inventory of a vault. Valid values are "select", "archive-retrieval" and "inventory-retrieval".</param>
        /// <param name="archiveId">The ID of the archive that you want to retrieve. This field is required only if <c>Type</c> is set to <c>select</c> or <c>archive-retrieval</c>code&gt;. An error occurs if you specify this request parameter for an inventory retrieval job request. </param>
        /// <param name="description">The optional description for the job. The description must be less than or equal to 1,024 bytes. The allowable characters are 7-bit ASCII without control codes-specifically, ASCII values 32-126 decimal or 0x20-0x7E hexadecimal.</param>
        public JobParameters(string format, string type, string archiveId, string description)
        {
            _format = format;
            _type = type;
            _archiveId = archiveId;
            _description = description;
        }

        /// <summary>
        /// Gets and sets the property ArchiveId. 
        /// <para>
        /// The ID of the archive that you want to retrieve. This field is required only if <c>Type</c>
        /// is set to <c>select</c> or <c>archive-retrieval</c>code&gt;. An error occurs if you
        /// specify this request parameter for an inventory retrieval job request. 
        /// </para>
        /// </summary>
        public string ArchiveId
        {
            get { return this._archiveId; }
            set { this._archiveId = value; }
        }

        // Check to see if ArchiveId property is set
        internal bool IsSetArchiveId()
        {
            return this._archiveId != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The optional description for the job. The description must be less than or equal to
        /// 1,024 bytes. The allowable characters are 7-bit ASCII without control codes-specifically,
        /// ASCII values 32-126 decimal or 0x20-0x7E hexadecimal.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Format. 
        /// <para>
        /// When initiating a job to retrieve a vault inventory, you can optionally add this parameter
        /// to your request to specify the output format. If you are initiating an inventory job
        /// and do not specify a Format field, JSON is the default format. Valid values are "CSV"
        /// and "JSON".
        /// </para>
        /// </summary>
        public string Format
        {
            get { return this._format; }
            set { this._format = value; }
        }

        // Check to see if Format property is set
        internal bool IsSetFormat()
        {
            return this._format != null;
        }

        /// <summary>
        /// Gets and sets the property InventoryRetrievalParameters. 
        /// <para>
        /// Input parameters used for range inventory retrieval.
        /// </para>
        /// </summary>
        public InventoryRetrievalJobInput InventoryRetrievalParameters
        {
            get { return this._inventoryRetrievalParameters; }
            set { this._inventoryRetrievalParameters = value; }
        }

        // Check to see if InventoryRetrievalParameters property is set
        internal bool IsSetInventoryRetrievalParameters()
        {
            return this._inventoryRetrievalParameters != null;
        }

        /// <summary>
        /// Gets and sets the property OutputLocation. 
        /// <para>
        /// Contains information about the location where the select job results are stored.
        /// </para>
        /// </summary>
        public OutputLocation OutputLocation
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
        /// Gets and sets the property RetrievalByteRange. 
        /// <para>
        /// The byte range to retrieve for an archive retrieval. in the form "<i>StartByteValue</i>-<i>EndByteValue</i>"
        /// If not specified, the whole archive is retrieved. If specified, the byte range must
        /// be megabyte (1024*1024) aligned which means that <i>StartByteValue</i> must be divisible
        /// by 1 MB and <i>EndByteValue</i> plus 1 must be divisible by 1 MB or be the end of
        /// the archive specified as the archive byte size value minus 1. If RetrievalByteRange
        /// is not megabyte aligned, this operation returns a 400 response. 
        /// </para>
        ///  
        /// <para>
        /// An error occurs if you specify this field for an inventory retrieval job request.
        /// </para>
        /// </summary>
        public string RetrievalByteRange
        {
            get { return this._retrievalByteRange; }
            set { this._retrievalByteRange = value; }
        }

        // Check to see if RetrievalByteRange property is set
        internal bool IsSetRetrievalByteRange()
        {
            return this._retrievalByteRange != null;
        }

        /// <summary>
        /// Gets and sets the property SelectParameters. 
        /// <para>
        /// Contains the parameters that define a job.
        /// </para>
        /// </summary>
        public SelectParameters SelectParameters
        {
            get { return this._selectParameters; }
            set { this._selectParameters = value; }
        }

        // Check to see if SelectParameters property is set
        internal bool IsSetSelectParameters()
        {
            return this._selectParameters != null;
        }

        /// <summary>
        /// Gets and sets the property SNSTopic. 
        /// <para>
        /// The Amazon SNS topic ARN to which Amazon S3 Glacier sends a notification when the
        /// job is completed and the output is ready for you to download. The specified topic
        /// publishes the notification to its subscribers. The SNS topic must exist.
        /// </para>
        /// </summary>
        public string SNSTopic
        {
            get { return this._snsTopic; }
            set { this._snsTopic = value; }
        }

        // Check to see if SNSTopic property is set
        internal bool IsSetSNSTopic()
        {
            return this._snsTopic != null;
        }

        /// <summary>
        /// Gets and sets the property Tier. 
        /// <para>
        /// The tier to use for a select or an archive retrieval job. Valid values are <c>Expedited</c>,
        /// <c>Standard</c>, or <c>Bulk</c>. <c>Standard</c> is the default.
        /// </para>
        /// </summary>
        public string Tier
        {
            get { return this._tier; }
            set { this._tier = value; }
        }

        // Check to see if Tier property is set
        internal bool IsSetTier()
        {
            return this._tier != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The job type. You can initiate a job to perform a select query on an archive, retrieve
        /// an archive, or get an inventory of a vault. Valid values are "select", "archive-retrieval"
        /// and "inventory-retrieval".
        /// </para>
        /// </summary>
        public string Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}