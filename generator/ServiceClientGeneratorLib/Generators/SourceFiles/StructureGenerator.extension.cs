using System.Text;

namespace ServiceClientGenerator.Generators.SourceFiles
{
    public partial class StructureGenerator
    {
        public string BaseClassString
        {
            get
            {
                if (!string.IsNullOrWhiteSpace(this.BaseClass))
                {
                    return " : " + this.BaseClass;
                }
                else
                {
                    return string.Empty;
                }
            }
        }

        public string GenerateEventPublisherDocumentation(Member member)
        {
            // Append adding "\n" is used instead of AppendLine to avoid the windows platform behavior of \r\n being used.
            var docs = new StringBuilder();
            docs.Append("<para>\n");
            docs.Append("The Func set for this property by the consumer of the SDK is used to stream events into the service. Consumers\n");
            docs.Append("provide a Func that the SDK will continue to call to get events to send. When the consumer is done streaming\n");
            docs.Append("events to the service the Func can return null to stop the SDK calling the Func for new events. The Func must\n");
            docs.Append($"return an event known by the service which can be identified by implementing the I{member.ModelShape.Name}Event\n");
            docs.Append("interface. The known implementatons in the SDK for this interface are:\n");

            docs.Append("<list type=\"bullet\">\n");
            foreach (var eventMember in member.Shape.Members)
            {
                if (!eventMember.Shape.IsEvent)
                    continue;

                docs.Append($"  <item><term><see cref=\"{eventMember.Shape.Name}\"/></term></item>\n");
            }
            docs.Append("</list>\n");
            docs.Append("</para>\n");


            return docs.ToString();
        }
    }
}
