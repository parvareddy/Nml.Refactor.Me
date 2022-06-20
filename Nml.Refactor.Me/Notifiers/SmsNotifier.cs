using System;
using System.Threading.Tasks;
using Nml.Refactor.Me.Dependencies;
using Nml.Refactor.Me.MessageBuilders;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace Nml.Refactor.Me.Notifiers
{
	public class SmsNotifier : INotifier
	{
		private readonly IStringMessageBuilder _messageBuilder;
		private readonly IOptions _options;
		private readonly ILogger _logger = LogManager.For<SmsNotifier>();

		public SmsNotifier(IStringMessageBuilder messageBuilder, IOptions options)
		{
			_messageBuilder = messageBuilder ?? throw new ArgumentNullException(nameof(messageBuilder));
			_options = options ?? throw new ArgumentNullException(nameof(options));
		}
		
		public async Task Notify(NotificationMessage message)
		{
            //Complete after refactoring inheritance. Use "SmsApiClient"   
            var mobileNumber = "1234567890";

            var message = SmsMessageBuilder.CreateMessage(
            Body: "Hi there"
        );
            await SmsApiClient.SendAsync(mobileNumber, message);
            SmsMessageBuilder.CreateMessage(message);
        }
	}
}
