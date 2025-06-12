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
 * Do not modify this file. This file is generated from the macie2-2020-01-01.normal.json service model.
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
namespace Amazon.Macie2.Model
{
    /// <summary>
    /// Container for the parameters to the CreateClassificationJob operation.
    /// Creates and defines the settings for a classification job.
    /// </summary>
    public partial class CreateClassificationJobRequest : AmazonMacie2Request
    {
        private List<string> _allowListIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _clientToken;
        private List<string> _customDataIdentifierIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _description;
        private bool? _initialRun;
        private JobType _jobType;
        private List<string> _managedDataIdentifierIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private ManagedDataIdentifierSelector _managedDataIdentifierSelector;
        private string _name;
        private S3JobDefinition _s3JobDefinition;
        private int? _samplingPercentage;
        private JobScheduleFrequency _scheduleFrequency;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property AllowListIds. 
        /// <para>
        /// An array of unique identifiers, one for each allow list for the job to use when it
        /// analyzes data.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AllowListIds
        {
            get { return this._allowListIds; }
            set { this._allowListIds = value; }
        }

        // Check to see if AllowListIds property is set
        internal bool IsSetAllowListIds()
        {
            return this._allowListIds != null && (this._allowListIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive token that you provide to ensure the idempotency of the request.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property CustomDataIdentifierIds. 
        /// <para>
        /// An array of unique identifiers, one for each custom data identifier for the job to
        /// use when it analyzes data. To use only managed data identifiers, don't specify a value
        /// for this property and specify a value other than NONE for the managedDataIdentifierSelector
        /// property.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> CustomDataIdentifierIds
        {
            get { return this._customDataIdentifierIds; }
            set { this._customDataIdentifierIds = value; }
        }

        // Check to see if CustomDataIdentifierIds property is set
        internal bool IsSetCustomDataIdentifierIds()
        {
            return this._customDataIdentifierIds != null && (this._customDataIdentifierIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A custom description of the job. The description can contain as many as 200 characters.
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
        /// Gets and sets the property InitialRun. 
        /// <para>
        /// For a recurring job, specifies whether to analyze all existing, eligible objects immediately
        /// after the job is created (true). To analyze only those objects that are created or
        /// changed after you create the job and before the job's first scheduled run, set this
        /// value to false.
        /// </para>
        ///  
        /// <para>
        /// If you configure the job to run only once, don't specify a value for this property.
        /// </para>
        /// </summary>
        public bool? InitialRun
        {
            get { return this._initialRun; }
            set { this._initialRun = value; }
        }

        // Check to see if InitialRun property is set
        internal bool IsSetInitialRun()
        {
            return this._initialRun.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property JobType. 
        /// <para>
        /// The schedule for running the job. Valid values are:
        /// </para>
        ///  <ul><li>
        /// <para>
        /// ONE_TIME - Run the job only once. If you specify this value, don't specify a value
        /// for the scheduleFrequency property.
        /// </para>
        /// </li> <li>
        /// <para>
        /// SCHEDULED - Run the job on a daily, weekly, or monthly basis. If you specify this
        /// value, use the scheduleFrequency property to specify the recurrence pattern for the
        /// job.
        /// </para>
        /// </li></ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public JobType JobType
        {
            get { return this._jobType; }
            set { this._jobType = value; }
        }

        // Check to see if JobType property is set
        internal bool IsSetJobType()
        {
            return this._jobType != null;
        }

        /// <summary>
        /// Gets and sets the property ManagedDataIdentifierIds. 
        /// <para>
        /// An array of unique identifiers, one for each managed data identifier for the job to
        /// include (use) or exclude (not use) when it analyzes data. Inclusion or exclusion depends
        /// on the managed data identifier selection type that you specify for the job (managedDataIdentifierSelector).
        /// </para>
        ///  
        /// <para>
        /// To retrieve a list of valid values for this property, use the ListManagedDataIdentifiers
        /// operation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ManagedDataIdentifierIds
        {
            get { return this._managedDataIdentifierIds; }
            set { this._managedDataIdentifierIds = value; }
        }

        // Check to see if ManagedDataIdentifierIds property is set
        internal bool IsSetManagedDataIdentifierIds()
        {
            return this._managedDataIdentifierIds != null && (this._managedDataIdentifierIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ManagedDataIdentifierSelector. 
        /// <para>
        /// The selection type to apply when determining which managed data identifiers the job
        /// uses to analyze data. Valid values are:
        /// </para>
        ///  <ul><li>
        /// <para>
        /// ALL - Use all managed data identifiers. If you specify this value, don't specify any
        /// values for the managedDataIdentifierIds property.
        /// </para>
        /// </li> <li>
        /// <para>
        /// EXCLUDE - Use all managed data identifiers except the ones specified by the managedDataIdentifierIds
        /// property.
        /// </para>
        /// </li> <li>
        /// <para>
        /// INCLUDE - Use only the managed data identifiers specified by the managedDataIdentifierIds
        /// property.
        /// </para>
        /// </li> <li>
        /// <para>
        /// NONE - Don't use any managed data identifiers. If you specify this value, specify
        /// at least one value for the customDataIdentifierIds property and don't specify any
        /// values for the managedDataIdentifierIds property.
        /// </para>
        /// </li> <li>
        /// <para>
        /// RECOMMENDED (default) - Use the recommended set of managed data identifiers. If you
        /// specify this value, don't specify any values for the managedDataIdentifierIds property.
        /// </para>
        /// </li></ul> 
        /// <para>
        /// If you don't specify a value for this property, the job uses the recommended set of
        /// managed data identifiers.
        /// </para>
        ///  
        /// <para>
        /// If the job is a recurring job and you specify ALL or EXCLUDE, each job run automatically
        /// uses new managed data identifiers that are released. If you don't specify a value
        /// for this property or you specify RECOMMENDED for a recurring job, each job run automatically
        /// uses all the managed data identifiers that are in the recommended set when the run
        /// starts.
        /// </para>
        ///  
        /// <para>
        /// To learn about individual managed data identifiers or determine which ones are in
        /// the recommended set, see <a href="https://docs.aws.amazon.com/macie/latest/user/managed-data-identifiers.html">Using
        /// managed data identifiers</a> or <a href="https://docs.aws.amazon.com/macie/latest/user/discovery-jobs-mdis-recommended.html">Recommended
        /// managed data identifiers</a> in the <i>Amazon Macie User Guide</i>.
        /// </para>
        /// </summary>
        public ManagedDataIdentifierSelector ManagedDataIdentifierSelector
        {
            get { return this._managedDataIdentifierSelector; }
            set { this._managedDataIdentifierSelector = value; }
        }

        // Check to see if ManagedDataIdentifierSelector property is set
        internal bool IsSetManagedDataIdentifierSelector()
        {
            return this._managedDataIdentifierSelector != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A custom name for the job. The name can contain as many as 500 characters.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property S3JobDefinition. 
        /// <para>
        /// The S3 buckets that contain the objects to analyze, and the scope of that analysis.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public S3JobDefinition S3JobDefinition
        {
            get { return this._s3JobDefinition; }
            set { this._s3JobDefinition = value; }
        }

        // Check to see if S3JobDefinition property is set
        internal bool IsSetS3JobDefinition()
        {
            return this._s3JobDefinition != null;
        }

        /// <summary>
        /// Gets and sets the property SamplingPercentage. 
        /// <para>
        /// The sampling depth, as a percentage, for the job to apply when processing objects.
        /// This value determines the percentage of eligible objects that the job analyzes. If
        /// this value is less than 100, Amazon Macie selects the objects to analyze at random,
        /// up to the specified percentage, and analyzes all the data in those objects.
        /// </para>
        /// </summary>
        public int? SamplingPercentage
        {
            get { return this._samplingPercentage; }
            set { this._samplingPercentage = value; }
        }

        // Check to see if SamplingPercentage property is set
        internal bool IsSetSamplingPercentage()
        {
            return this._samplingPercentage.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ScheduleFrequency. 
        /// <para>
        /// The recurrence pattern for running the job. To run the job only once, don't specify
        /// a value for this property and set the value for the jobType property to ONE_TIME.
        /// </para>
        /// </summary>
        public JobScheduleFrequency ScheduleFrequency
        {
            get { return this._scheduleFrequency; }
            set { this._scheduleFrequency = value; }
        }

        // Check to see if ScheduleFrequency property is set
        internal bool IsSetScheduleFrequency()
        {
            return this._scheduleFrequency != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A map of key-value pairs that specifies the tags to associate with the job.
        /// </para>
        ///  
        /// <para>
        /// A job can have a maximum of 50 tags. Each tag consists of a tag key and an associated
        /// tag value. The maximum length of a tag key is 128 characters. The maximum length of
        /// a tag value is 256 characters.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
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