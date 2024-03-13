using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.S3.Model
{
    /// <summary>
    /// Specifies the restoration status of an object. Objects in certain storage classes
    /// must be restored before they can be retrieved. For more information about these storage
    /// classes and how to work with archived objects, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/archived-objects.html">
    /// Working with archived objects</a> in the <i>Amazon S3 User Guide</i>.
    /// 
    ///  <note> 
    /// <para>
    /// This functionality is not supported for directory buckets. Only the S3 Express One
    /// Zone storage class is supported by directory buckets to store objects.
    /// </para>
    ///  </note>
    /// </summary>
    public class RestoreStatus
    {
        private bool? _isRestoreInProgress;
        private DateTime? _restoreExpiryDate;

        /// <summary>
        /// Gets and sets the property IsRestoreInProgress. 
        /// <para>
        /// Specifies whether the object is currently being restored. If the object restoration
        /// is in progress, the header returns the value <code>TRUE</code>. For example:
        /// </para>
        ///  
        /// <para>
        ///  <code>x-amz-optional-object-attributes: IsRestoreInProgress="true"</code> 
        /// </para>
        ///  
        /// <para>
        /// If the object restoration has completed, the header returns the value <code>FALSE</code>.
        /// For example:
        /// </para>
        ///  
        /// <para>
        ///  <code>x-amz-optional-object-attributes: IsRestoreInProgress="false", RestoreExpiryDate="2012-12-21T00:00:00.000Z"</code>
        /// 
        /// </para>
        ///  
        /// <para>
        /// If the object hasn't been restored, there is no header response.
        /// </para>
        /// </summary>
        public bool? IsRestoreInProgress
        {
            get { return this._isRestoreInProgress; }
            set { this._isRestoreInProgress = value; }
        }

        // Check to see if IsRestoreInProgress property is set
        internal bool IsSetIsRestoreInProgress()
        {
            return this._isRestoreInProgress.HasValue;
        }

        /// <summary>
        /// Gets and sets the property RestoreExpiryDate. 
        /// <para>
        /// Indicates when the restored copy will expire. This value is populated only if the
        /// object has already been restored. For example:
        /// </para>
        ///  
        /// <para>
        ///  <code>x-amz-optional-object-attributes: IsRestoreInProgress="false", RestoreExpiryDate="2012-12-21T00:00:00.000Z"</code>
        /// 
        /// </para>
        /// </summary>
        public DateTime? RestoreExpiryDate
        {
            get { return this._restoreExpiryDate; }
            set { this._restoreExpiryDate = value; }
        }

        // Check to see if RestoreExpiryDate property is set
        internal bool IsSetRestoreExpiryDate()
        {
            return this._restoreExpiryDate.HasValue;
        }

    }
}
