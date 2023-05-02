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

namespace Amazon.S3.Model
{
    /// <summary>
    /// Optional configuration to replicate existing source bucket objects. For more information,
    /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/replication-what-is-isnot-replicated.html#existing-object-replication">Replicating
    /// Existing Objects</a> in the <i>Amazon S3 User Guide</i>.
    /// </summary>
    public class ExistingObjectReplication
    {
        /// <summary>
        /// <para>
        /// Specifies whether Amazon S3 replicates existing source bucket objects.
        /// </para>
        /// </summary>
        public ExistingObjectReplicationStatus Status { get; set; }

        internal bool IsSetExistingObjectReplicationStatus()
        {
            return this.Status != null;
        }
    }
}
