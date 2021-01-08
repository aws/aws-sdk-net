using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Amazon.S3Control.Model
{
    public partial class CreateAccessPointRequest : AmazonS3ControlRequest
    {
        internal string OutpostId { get; set; }
    }
}
